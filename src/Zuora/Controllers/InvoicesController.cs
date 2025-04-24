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
    /// Controller para gerenciamento de faturas
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    [Produces("application/json")]
    public class InvoicesController : ControllerBase
    {
        private readonly InvoicesApi _invoicesApi;
        private readonly ILogger<InvoicesController> _logger;

        public InvoicesController(InvoicesApi invoicesApi, ILogger<InvoicesController> logger)
        {
            _invoicesApi = invoicesApi;
            _logger = logger;
        }

        /// <summary>
        /// Obtém todas as faturas com paginação
        /// </summary>
        /// <param name="page">Número da página (mínimo: 1)</param>
        /// <param name="pageSize">Tamanho da página (mínimo: 1, máximo: 100)</param>
        /// <returns>Lista de faturas</returns>
        /// <response code="200">Retorna a lista de faturas</response>
        /// <response code="400">Se os parâmetros forem inválidos</response>
        /// <response code="401">Se o usuário não estiver autenticado</response>
        /// <response code="403">Se o usuário não tiver permissão</response>
        [HttpGet]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetInvoices(
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

                var invoices = await _invoicesApi.GetInvoicesAsync();
                _logger.LogInformation($"Retornando {invoices.data.Count} faturas da página {page}");
                return Ok(invoices);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar faturas");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Obtém uma fatura específica pelo ID
        /// </summary>
        /// <param name="id">ID da fatura</param>
        /// <returns>Dados da fatura</returns>
        /// <response code="200">Retorna a fatura solicitada</response>
        /// <response code="400">Se o ID for inválido</response>
        /// <response code="404">Se a fatura não for encontrada</response>
        [HttpGet("{id}")]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetInvoice([Required] string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    return BadRequest("ID da fatura é obrigatório.");
                }

                var invoice = await _invoicesApi.GetInvoiceAsync(id);
                if (invoice == null)
                {
                    return NotFound($"Fatura com ID {id} não encontrada.");
                }

                return Ok(invoice);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar fatura com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Cria uma nova fatura
        /// </summary>
        /// <param name="request">Dados da fatura a ser criada</param>
        /// <returns>Fatura criada</returns>
        /// <response code="201">Retorna a fatura criada</response>
        /// <response code="400">Se os dados da fatura forem inválidos</response>
        [HttpPost]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateInvoice([FromBody] InvoiceCreateRequest request)
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

                if (request.items == null || !request.items.Any())
                {
                    return BadRequest("A fatura deve conter pelo menos um item.");
                }

                foreach (var item in request.items)
                {
                    if (string.IsNullOrWhiteSpace(item.sku))
                    {
                        return BadRequest("O ID do produto é obrigatório para todos os itens.");
                    }

                    if (item.quantity <= 0)
                    {
                        return BadRequest("A quantidade deve ser maior que zero para todos os itens.");
                    }

                    if (item.unit_amount < 0)
                    {
                        return BadRequest("O preço unitário não pode ser negativo.");
                    }
                }

                var invoice = await _invoicesApi.CreateInvoiceAsync(request);
                return CreatedAtAction(nameof(GetInvoice), new { id = invoice.id }, invoice);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar fatura");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Atualiza uma fatura existente
        /// </summary>
        /// <param name="id">ID da fatura</param>
        /// <param name="request">Dados atualizados da fatura</param>
        /// <returns>Fatura atualizada</returns>
        /// <response code="200">Retorna a fatura atualizada</response>
        /// <response code="400">Se os dados da fatura forem inválidos</response>
        /// <response code="404">Se a fatura não for encontrada</response>
        [HttpPut("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateInvoice([Required] string id, [FromBody] InvoicePatchRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }


                var invoice =  _invoicesApi.PatchInvoice(id, request);
                return Ok(invoice);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao atualizar fatura com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Deleta uma fatura
        /// </summary>
        /// <param name="id">ID da fatura</param>
        /// <returns>Sem conteúdo</returns>
        /// <response code="204">Se a fatura for deletada com sucesso</response>
        /// <response code="404">Se a fatura não for encontrada</response>
        [HttpDelete("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteInvoice([Required] string id)
        {
            try
            {
                await _invoicesApi.DeleteInvoiceAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar fatura com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Posta uma fatura
        /// </summary>
        /// <param name="id">ID da fatura</param>
        /// <returns>Fatura postada</returns>
        /// <response code="200">Retorna a fatura postada</response>
        /// <response code="400">Se o ID for inválido</response>
        /// <response code="404">Se a fatura não for encontrada</response>
        [HttpPost("{id}/post")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PostInvoice([Required] string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    return BadRequest("ID da fatura é obrigatório.");
                }

                var result = await _invoicesApi.PostInvoiceAsync(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao postar fatura com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

      
    }
} 