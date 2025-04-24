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
    /// Controller para gerenciamento de pedidos
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    [Produces("application/json")]
    public class OrdersController : ControllerBase
    {
        private readonly OrdersApi _ordersApi;
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(OrdersApi ordersApi, ILogger<OrdersController> logger)
        {
            _ordersApi = ordersApi;
            _logger = logger;
        }

        /// <summary>
        /// Obtém todos os pedidos com paginação
        /// </summary>
        /// <param name="page">Número da página (mínimo: 1)</param>
        /// <param name="pageSize">Tamanho da página (mínimo: 1, máximo: 100)</param>
        /// <returns>Lista de pedidos</returns>
        /// <response code="200">Retorna a lista de pedidos</response>
        /// <response code="400">Se os parâmetros forem inválidos</response>
        /// <response code="401">Se o usuário não estiver autenticado</response>
        /// <response code="403">Se o usuário não tiver permissão</response>
        [HttpGet]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetOrders(
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

                var orders = await _ordersApi.GetOrdersAsync();
                _logger.LogInformation($"Retornando {orders.data.Count} pedidos da página {page}");
                return Ok(orders);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar pedidos");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Obtém um pedido específico pelo ID
        /// </summary>
        /// <param name="id">ID do pedido</param>
        /// <returns>Dados do pedido</returns>
        /// <response code="200">Retorna o pedido solicitado</response>
        /// <response code="400">Se o ID for inválido</response>
        /// <response code="404">Se o pedido não for encontrado</response>
        [HttpGet("{id}")]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetOrder([Required] string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    return BadRequest("ID do pedido é obrigatório.");
                }

                var order = await _ordersApi.GetOrderAsync(id);
                if (order == null)
                {
                    return NotFound($"Pedido com ID {id} não encontrado.");
                }

                return Ok(order);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar pedido com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Cria um novo pedido
        /// </summary>
        /// <param name="request">Dados do pedido a ser criado</param>
        /// <returns>Pedido criado</returns>
        /// <response code="201">Retorna o pedido criado</response>
        /// <response code="400">Se os dados do pedido forem inválidos</response>
        [HttpPost]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateOrder([FromBody] OrderCreateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Validações específicas de negócio
                if (string.IsNullOrWhiteSpace(request.account_id) && string.IsNullOrWhiteSpace(request.account_number))
                {
                    return BadRequest("O ID da conta ou número da conta é obrigatório.");
                }

                if (request.line_items == null || !request.line_items.Any())
                {
                    return BadRequest("O pedido deve conter pelo menos um item.");
                }

                foreach (var item in request.line_items)
                {
                    if (string.IsNullOrWhiteSpace(item.product_code))
                    {
                        return BadRequest("O código do produto é obrigatório para todos os itens.");
                    }

                    if (item.quantity <= 0)
                    {
                        return BadRequest("A quantidade deve ser maior que zero para todos os itens.");
                    }
                }

                var order = await _ordersApi.CreateOrderAsync(request);
                return CreatedAtAction(nameof(GetOrder), new { id = order.id }, order);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar pedido");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }


        /// <summary>
        /// Deleta um pedido
        /// </summary>
        /// <param name="id">ID do pedido</param>
        /// <returns>Sem conteúdo</returns>
        /// <response code="204">Se o pedido for deletado com sucesso</response>
        /// <response code="404">Se o pedido não for encontrado</response>
        [HttpDelete("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteOrder([Required] string id)
        {
            try
            {
                await _ordersApi.DeleteOrderAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar pedido com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }
    }
} 