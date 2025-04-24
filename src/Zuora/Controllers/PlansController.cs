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
    /// Controller para gerenciamento de planos
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    [Produces("application/json")]
    public class PlansController : ControllerBase
    {
        private readonly PlansApi _plansApi;
        private readonly ILogger<PlansController> _logger;

        public PlansController(PlansApi plansApi, ILogger<PlansController> logger)
        {
            _plansApi = plansApi;
            _logger = logger;
        }

        /// <summary>
        /// Obtém todos os planos com paginação
        /// </summary>
        /// <param name="page">Número da página (mínimo: 1)</param>
        /// <param name="pageSize">Tamanho da página (mínimo: 1, máximo: 100)</param>
        /// <returns>Lista de planos</returns>
        /// <response code="200">Retorna a lista de planos</response>
        /// <response code="400">Se os parâmetros de paginação forem inválidos</response>
        /// <response code="401">Se o usuário não estiver autenticado</response>
        /// <response code="403">Se o usuário não tiver permissão</response>
        [HttpGet]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetPlans([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
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

                var plans = await _plansApi.GetPlansAsync();
                _logger.LogInformation($"Retornando {plans.data.Count} planos da página {page}");
                return Ok(plans);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar planos");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Obtém um plano específico pelo ID
        /// </summary>
        /// <param name="id">ID do plano</param>
        /// <returns>Dados do plano</returns>
        /// <response code="200">Retorna o plano solicitado</response>
        /// <response code="400">Se o ID for inválido</response>
        /// <response code="404">Se o plano não for encontrado</response>
        [HttpGet("{id}")]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPlan([Required] string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    return BadRequest("ID do plano é obrigatório.");
                }

                var plan = await _plansApi.GetPlanAsync(id);
                if (plan == null)
                {
                    return NotFound($"Plano com ID {id} não encontrado.");
                }

                return Ok(plan);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar plano com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Cria um novo plano
        /// </summary>
        /// <param name="request">Dados do plano a ser criado</param>
        /// <returns>Plano criado</returns>
        /// <response code="201">Retorna o plano criado</response>
        /// <response code="400">Se os dados do plano forem inválidos</response>
        [HttpPost]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreatePlan([FromBody] PlanCreateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Validações específicas de negócio
                if (string.IsNullOrWhiteSpace(request.name))
                {
                    return BadRequest("O nome do plano é obrigatório.");
                }


                var plan = await _plansApi.CreatePlanAsync(request);
                return CreatedAtAction(nameof(GetPlan), new { id = plan.id }, plan);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar plano");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Atualiza um plano existente
        /// </summary>
        /// <param name="id">ID do plano</param>
        /// <param name="request">Dados atualizados do plano</param>
        /// <returns>Plano atualizado</returns>
        /// <response code="200">Retorna o plano atualizado</response>
        /// <response code="400">Se os dados do plano forem inválidos</response>
        /// <response code="404">Se o plano não for encontrado</response>
        [HttpPut("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdatePlan([Required] string id, [FromBody] PlanPatchRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Validações específicas de negócio
                if (string.IsNullOrWhiteSpace(request.name))
                {
                    return BadRequest("O nome do plano é obrigatório.");
                }

                var plan = await _plansApi.UpdatePlanAsync(id, request);
                return Ok(plan);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao atualizar plano com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Deleta um plano
        /// </summary>
        /// <param name="id">ID do plano</param>
        /// <returns>Sem conteúdo</returns>
        /// <response code="204">Se o plano for deletado com sucesso</response>
        /// <response code="404">Se o plano não for encontrado</response>
        [HttpDelete("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeletePlan([Required] string id)
        {
            try
            {
                await _plansApi.DeletePlanAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar plano com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }
    }
} 