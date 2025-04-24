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
    /// Controller para gerenciamento de produtos
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsApi _productsApi;
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ProductsApi productsApi, ILogger<ProductsController> logger)
        {
            _productsApi = productsApi;
            _logger = logger;
        }

        /// <summary>
        /// Obtém todos os produtos com paginação
        /// </summary>
        /// <param name="page">Número da página (mínimo: 1)</param>
        /// <param name="pageSize">Tamanho da página (mínimo: 1, máximo: 100)</param>
        /// <returns>Lista de produtos</returns>
        /// <response code="200">Retorna a lista de produtos</response>
        /// <response code="400">Se os parâmetros de paginação forem inválidos</response>
        /// <response code="401">Se o usuário não estiver autenticado</response>
        /// <response code="403">Se o usuário não tiver permissão</response>
        [HttpGet]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetProducts([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
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

                var products = await _productsApi.GetProductsAsync();
                _logger.LogInformation($"Retornando {products.data.Count} produtos da página {page}");
                return Ok(products);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar produtos");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Obtém um produto específico pelo ID
        /// </summary>
        /// <param name="id">ID do produto</param>
        /// <returns>Dados do produto</returns>
        /// <response code="200">Retorna o produto solicitado</response>
        /// <response code="400">Se o ID for inválido</response>
        /// <response code="404">Se o produto não for encontrado</response>
        [HttpGet("{id}")]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProduct([Required] string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    return BadRequest("ID do produto é obrigatório.");
                }

                var product = await _productsApi.GetProductAsync(id);
                if (product == null)
                {
                    return NotFound($"Produto com ID {id} não encontrado.");
                }

                return Ok(product);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar produto com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Cria um novo produto
        /// </summary>
        /// <param name="request">Dados do produto a ser criado</param>
        /// <returns>Produto criado</returns>
        /// <response code="201">Retorna o produto criado</response>
        /// <response code="400">Se os dados do produto forem inválidos</response>
        [HttpPost]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateProduct([FromBody] ProductCreateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Validações específicas de negócio
               

                if (string.IsNullOrWhiteSpace(request.sku))
                {
                    return BadRequest("O SKU do produto é obrigatório.");
                }

                var product = await _productsApi.CreateProductAsync(request);
                return CreatedAtAction(nameof(GetProduct), new { id = product.id }, product);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar produto");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Atualiza um produto existente
        /// </summary>
        /// <param name="id">ID do produto</param>
        /// <param name="request">Dados atualizados do produto</param>
        /// <returns>Produto atualizado</returns>
        /// <response code="200">Retorna o produto atualizado</response>
        /// <response code="400">Se os dados do produto forem inválidos</response>
        /// <response code="404">Se o produto não for encontrado</response>
        [HttpPut("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateProduct([Required] string id, [FromBody] ProductPatchRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

               
                var product = await _productsApi.UpdateProductAsync(id, request);
                return Ok(product);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao atualizar produto com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Deleta um produto
        /// </summary>
        /// <param name="id">ID do produto</param>
        /// <returns>Sem conteúdo</returns>
        /// <response code="204">Se o produto for deletado com sucesso</response>
        /// <response code="404">Se o produto não for encontrado</response>
        [HttpDelete("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProduct([Required] string id)
        {
            try
            {
                await _productsApi.DeleteProductAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar produto com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }
    }
} 