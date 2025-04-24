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
    /// Controller para gerenciamento de preços
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    [Produces("application/json")]
    public class PricesController : ControllerBase
    {
        private readonly PricesApi _pricesApi;
        private readonly ILogger<PricesController> _logger;

        public PricesController(PricesApi pricesApi, ILogger<PricesController> logger)
        {
            _pricesApi = pricesApi;
            _logger = logger;
        }

        /// <summary>
        /// Obtém todos os preços com paginação
        /// </summary>
        /// <param name="page">Número da página (mínimo: 1)</param>
        /// <param name="pageSize">Tamanho da página (mínimo: 1, máximo: 100)</param>
        /// <returns>Lista de preços</returns>
        /// <response code="200">Retorna a lista de preços</response>
        /// <response code="400">Se os parâmetros de paginação forem inválidos</response>
        /// <response code="401">Se o usuário não estiver autenticado</response>
        /// <response code="403">Se o usuário não tiver permissão</response>
        [HttpGet]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetPrices([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
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

                var prices = await _pricesApi.GetPricesAsync();
                _logger.LogInformation($"Retornando {prices.data.Count} preços da página {page}");
                return Ok(prices);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar preços");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Obtém um preço específico pelo ID
        /// </summary>
        /// <param name="id">ID do preço</param>
        /// <returns>Dados do preço</returns>
        /// <response code="200">Retorna o preço solicitado</response>
        /// <response code="400">Se o ID for inválido</response>
        /// <response code="404">Se o preço não for encontrado</response>
        [HttpGet("{id}")]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPrice([Required] string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    return BadRequest("ID do preço é obrigatório.");
                }

                var price = await _pricesApi.GetPriceAsync(id);
                if (price == null)
                {
                    return NotFound($"Preço com ID {id} não encontrado.");
                }

                return Ok(price);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar preço com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Cria um novo preço
        /// </summary>
        /// <param name="request">Dados do preço a ser criado</param>
        /// <returns>Preço criado</returns>
        /// <response code="201">Retorna o preço criado</response>
        /// <response code="400">Se os dados do preço forem inválidos</response>
        [HttpPost]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreatePrice([FromBody] PriceCreateRequest request)
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
                //    return BadRequest("O valor do preço deve ser maior que zero.");
                //}

                //if (string.IsNullOrWhiteSpace(request.currency))
                //{
                //    return BadRequest("A moeda do preço é obrigatória.");
                //}

                //if (string.IsNullOrWhiteSpace(request.product_id))
                //{
                //    return BadRequest("O ID do produto é obrigatório.");
                //}

                var price = await _pricesApi.CreatePriceAsync(request);
                return CreatedAtAction(nameof(GetPrice), new { id = price.id }, price);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar preço");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Atualiza um preço existente
        /// </summary>
        /// <param name="id">ID do preço</param>
        /// <param name="request">Dados atualizados do preço</param>
        /// <returns>Preço atualizado</returns>
        /// <response code="200">Retorna o preço atualizado</response>
        /// <response code="400">Se os dados do preço forem inválidos</response>
        /// <response code="404">Se o preço não for encontrado</response>
        [HttpPut("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdatePrice([Required] string id, [FromBody] PricePatchRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Validações específicas de negócio


                var price = await _pricesApi.PatchPriceAsync(id, request);
                return Ok(price);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao atualizar preço com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Deleta um preço
        /// </summary>
        /// <param name="id">ID do preço</param>
        /// <returns>Sem conteúdo</returns>
        /// <response code="204">Se o preço for deletado com sucesso</response>
        /// <response code="404">Se o preço não for encontrado</response>
        [HttpDelete("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeletePrice([Required] string id)
        {
            try
            {
                await _pricesApi.DeletePriceAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar preço com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }
    }
} 