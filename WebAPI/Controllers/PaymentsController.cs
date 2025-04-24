using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Zuora.Api;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Zuora.Model;

namespace Zuora.WebAPI.Controllers
{
    /// <summary>
    /// Controller para gerenciamento de pagamentos
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    [Produces("application/json")]
    public class PaymentsController : ControllerBase
    {
        private readonly PaymentsApi _paymentsApi;
        private readonly ILogger<PaymentsController> _logger;

        public PaymentsController(PaymentsApi paymentsApi, ILogger<PaymentsController> logger)
        {
            _paymentsApi = paymentsApi;
            _logger = logger;
        }

        /// <summary>
        /// Obtém todos os pagamentos com paginação
        /// </summary>
        /// <param name="page">Número da página (mínimo: 1)</param>
        /// <param name="pageSize">Tamanho da página (mínimo: 1, máximo: 100)</param>
        /// <returns>Lista de pagamentos</returns>
        /// <response code="200">Retorna a lista de pagamentos</response>
        /// <response code="400">Se os parâmetros forem inválidos</response>
        /// <response code="401">Se o usuário não estiver autenticado</response>
        /// <response code="403">Se o usuário não tiver permissão</response>
        [HttpGet]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetPayments(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10)
        {
            try
            {
                if (page < 1)
                {
                    return BadRequest("O número da página deve ser maior que zero.");
                }

                if (pageSize < 1 || pageSize > 100)
                {
                    return BadRequest("O tamanho da página deve estar entre 1 e 100.");
                }

                var payments = await _paymentsApi.GetPaymentsAsync();
                _logger.LogInformation($"Retornando {payments.data.Count} pagamentos da página {page}");
                return Ok(payments);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar pagamentos");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Obtém um pagamento específico pelo ID
        /// </summary>
        /// <param name="id">ID do pagamento</param>
        /// <returns>Dados do pagamento</returns>
        /// <response code="200">Retorna o pagamento solicitado</response>
        /// <response code="400">Se o ID for inválido</response>
        /// <response code="404">Se o pagamento não for encontrado</response>
        [HttpGet("{id}")]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPayment([Required] string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    return BadRequest("ID do pagamento é obrigatório.");
                }

                var payment = await _paymentsApi.GetPaymentAsync(id);
                if (payment == null)
                {
                    return NotFound($"Pagamento com ID {id} não encontrado.");
                }

                return Ok(payment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar pagamento com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Cria um novo pagamento
        /// </summary>
        /// <param name="request">Dados do pagamento a ser criado</param>
        /// <returns>Pagamento criado</returns>
        /// <response code="201">Retorna o pagamento criado</response>
        /// <response code="400">Se os dados do pagamento forem inválidos</response>
        [HttpPost]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreatePayment([FromBody] PaymentCreateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Validações específicas de negócio
                if (string.IsNullOrWhiteSpace(request.account_id))
                {
                    return BadRequest("O ID da conta é obrigatório.");
                }

   
                if (request.amount <= 0)
                {
                    return BadRequest("O valor do pagamento deve ser maior que zero.");
                }

                if (string.IsNullOrWhiteSpace(request.payment_method_id))
                {
                    return BadRequest("O ID do método de pagamento é obrigatório.");
                }

                var payment = await _paymentsApi.CreatePaymentAsync(request);
                return CreatedAtAction(nameof(GetPayment), new { id = payment.id }, payment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar pagamento");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Atualiza um pagamento existente
        /// </summary>
        /// <param name="id">ID do pagamento</param>
        /// <param name="request">Dados atualizados do pagamento</param>
        /// <returns>Pagamento atualizado</returns>
        /// <response code="200">Retorna o pagamento atualizado</response>
        /// <response code="400">Se os dados do pagamento forem inválidos</response>
        /// <response code="404">Se o pagamento não for encontrado</response>
        [HttpPut("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdatePayment([Required] string id, [FromBody] PaymentPatchRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Validações específicas de negócio
                //if (request.amount <= 0)
                //{
                //    return BadRequest("O valor do pagamento deve ser maior que zero.");
                //}

                var payment = await _paymentsApi.UpdatePaymentAsync(id, request);
                return Ok(payment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao atualizar pagamento com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Deleta um pagamento
        /// </summary>
        /// <param name="id">ID do pagamento</param>
        /// <returns>Sem conteúdo</returns>
        /// <response code="204">Se o pagamento for deletado com sucesso</response>
        /// <response code="404">Se o pagamento não for encontrado</response>
        [HttpDelete("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UnapplyPayment([Required] string id, PaymentApplyUnapplyRequest request)
        {
            try
            {
                var payment = _paymentsApi.UnapplyPayment(id, request);
                return Ok(payment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar pagamento com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

    }
} 