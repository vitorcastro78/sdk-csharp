using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Zuora.Api;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Zuora.Model;
using Microsoft.Extensions.Logging;

namespace Zuora.WebAPI.Controllers
{
    /// <summary>
    /// Controller para gerenciamento de reembolsos
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    [Produces("application/json")]
    public class RefundsController : ControllerBase
    {
        private readonly RefundsApi _refundsApi;
        private readonly ILogger<RefundsController> _logger;

        public RefundsController(RefundsApi refundsApi, ILogger<RefundsController> logger)
        {
            _refundsApi = refundsApi;
            _logger = logger;
        }

        /// <summary>
        /// Obtém todos os reembolsos com paginação
        /// </summary>
        /// <param name="page">Número da página (mínimo: 1)</param>
        /// <param name="pageSize">Tamanho da página (mínimo: 1, máximo: 100)</param>
        /// <returns>Lista de reembolsos</returns>
        /// <response code="200">Retorna a lista de reembolsos</response>
        /// <response code="400">Se os parâmetros forem inválidos</response>
        /// <response code="401">Se o usuário não estiver autenticado</response>
        /// <response code="403">Se o usuário não tiver permissão</response>
        [HttpGet]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetRefunds(
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

                var refunds = await _refundsApi.GetRefundsAsync();
                _logger.LogInformation($"Retornando {refunds.data.Count} reembolsos da página {page}");
                return Ok(refunds);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar reembolsos");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Obtém um reembolso específico pelo ID
        /// </summary>
        /// <param name="id">ID do reembolso</param>
        /// <returns>Dados do reembolso</returns>
        /// <response code="200">Retorna o reembolso solicitado</response>
        /// <response code="400">Se o ID for inválido</response>
        /// <response code="404">Se o reembolso não for encontrado</response>
        [HttpGet("{id}")]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetRefund([Required] string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    return BadRequest("ID do reembolso é obrigatório.");
                }

                var refund = await _refundsApi.GetRefundAsync(id);
                if (refund == null)
                {
                    return NotFound($"Reembolso com ID {id} não encontrado.");
                }

                return Ok(refund);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar reembolso com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Cria um novo reembolso
        /// </summary>
        /// <param name="request">Dados do reembolso a ser criado</param>
        /// <returns>Reembolso criado</returns>
        /// <response code="201">Retorna o reembolso criado</response>
        /// <response code="400">Se os dados do reembolso forem inválidos</response>
        [HttpPost]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateRefund([FromBody] RefundCreateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Validações específicas de negócio
                if (string.IsNullOrWhiteSpace(request.payment_id))
                {
                    return BadRequest("O ID do pagamento é obrigatório.");
                }

                if (request.amount <= 0)
                {
                    return BadRequest("O valor do reembolso deve ser maior que zero.");
                }


                var refund = await _refundsApi.CreateRefundAsync(request);
                return CreatedAtAction(nameof(GetRefund), new { id = refund.id }, refund);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar reembolso");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Atualiza um reembolso existente
        /// </summary>
        /// <param name="id">ID do reembolso</param>
        /// <param name="request">Dados atualizados do reembolso</param>
        /// <returns>Reembolso atualizado</returns>
        /// <response code="200">Retorna o reembolso atualizado</response>
        /// <response code="400">Se os dados do reembolso forem inválidos</response>
        /// <response code="404">Se o reembolso não for encontrado</response>
        [HttpPut("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateRefund([Required] string id, [FromBody] RefundPatchRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Validações específicas de negócio
               
                var refund = await _refundsApi.UpdateRefundAsync(id, request);
                return Ok(refund);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao atualizar reembolso com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Deleta um reembolso
        /// </summary>
        /// <param name="id">ID do reembolso</param>
        /// <returns>Sem conteúdo</returns>
        /// <response code="204">Se o reembolso for deletado com sucesso</response>
        /// <response code="404">Se o reembolso não for encontrado</response>
        [HttpDelete("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteRefund([Required] string id)
        {
            try
            {
                await _refundsApi.DeleteRefundAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar reembolso com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }
    }
} 