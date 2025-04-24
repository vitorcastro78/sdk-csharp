using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Zuora.Api;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Zuora.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Zuora.WebAPI.Controllers
{
    /// <summary>
    /// Controller para gerenciamento de itens de assinatura
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    [Produces("application/json")]
    public class SubscriptionItemsController : ControllerBase
    {
        private readonly SubscriptionItemsApi _subscriptionItemsApi;
        private readonly ILogger<SubscriptionItemsController> _logger;

        public SubscriptionItemsController(SubscriptionItemsApi subscriptionItemsApi, ILogger<SubscriptionItemsController> logger)
        {
            _subscriptionItemsApi = subscriptionItemsApi;
            _logger = logger;
        }

        /// <summary>
        /// Obtém todos os itens de assinatura com paginação
        /// </summary>
        /// <param name="subscriptionId">ID da assinatura</param>
        /// <param name="page">Número da página (mínimo: 1)</param>
        /// <param name="pageSize">Tamanho da página (mínimo: 1, máximo: 100)</param>
        /// <returns>Lista de itens de assinatura</returns>
        /// <response code="200">Retorna a lista de itens de assinatura</response>
        /// <response code="400">Se os parâmetros forem inválidos</response>
        /// <response code="401">Se o usuário não estiver autenticado</response>
        /// <response code="403">Se o usuário não tiver permissão</response>
        [HttpGet]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetSubscriptionItems(
            [FromQuery] string subscriptionId,
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(subscriptionId))
                {
                    return BadRequest("ID da assinatura é obrigatório.");
                }

                if (page < 1)
                {
                    return BadRequest("O número da página deve ser maior que zero.");
                }

                if (pageSize < 1 || pageSize > 100)
                {
                    return BadRequest("O tamanho da página deve estar entre 1 e 100.");
                }

                var items = await _subscriptionItemsApi.GetSubscriptionItemsAsync(subscriptionId);
                _logger.LogInformation($"Retornando {items.data.Count} itens da assinatura {subscriptionId} da página {page}");
                return Ok(items);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar itens de assinatura");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Obtém um item de assinatura específico pelo ID
        /// </summary>
        /// <param name="id">ID do item de assinatura</param>
        /// <returns>Dados do item de assinatura</returns>
        /// <response code="200">Retorna o item de assinatura solicitado</response>
        /// <response code="400">Se o ID for inválido</response>
        /// <response code="404">Se o item de assinatura não for encontrado</response>
        [HttpGet("{id}")]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetSubscriptionItem([Required] string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    return BadRequest("ID do item de assinatura é obrigatório.");
                }

                var item =  _subscriptionItemsApi.GetSubscriptionItems();
                if (item == null)
                {
                    return NotFound($"Item de assinatura com ID {id} não encontrado.");
                }

                return Ok(item.data.FirstOrDefault(f => f.id == id));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar item de assinatura com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

    }
} 