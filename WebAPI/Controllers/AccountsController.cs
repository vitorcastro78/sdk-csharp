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
    /// Controller para gerenciamento de contas
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    [Produces("application/json")]
    public class AccountsController : ControllerBase
    {
        private readonly AccountsApi _accountsApi;
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(AccountsApi accountsApi, ILogger<AccountsController> logger)
        {
            _accountsApi = accountsApi;
            _logger = logger;
        }

        /// <summary>
        /// Obtém todas as contas com paginação
        /// </summary>
        /// <param name="page">Número da página (mínimo: 1)</param>
        /// <param name="pageSize">Tamanho da página (mínimo: 1, máximo: 100)</param>
        /// <returns>Lista de contas</returns>
        /// <response code="200">Retorna a lista de contas</response>
        /// <response code="400">Se os parâmetros forem inválidos</response>
        /// <response code="401">Se o usuário não estiver autenticado</response>
        /// <response code="403">Se o usuário não tiver permissão</response>
        [HttpGet]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetAccounts(
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

                var accounts = await _accountsApi.GetAccountsAsync();
                _logger.LogInformation($"Retornando {accounts.data.Count} contas da página {page}");
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar contas");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Obtém uma conta específica pelo ID
        /// </summary>
        /// <param name="id">ID da conta</param>
        /// <returns>Dados da conta</returns>
        /// <response code="200">Retorna a conta solicitada</response>
        /// <response code="400">Se o ID for inválido</response>
        /// <response code="404">Se a conta não for encontrada</response>
        [HttpGet("{id}")]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAccount([Required] string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    return BadRequest("ID da conta é obrigatório.");
                }

                var account = await _accountsApi.GetAccountAsync(id);
                if (account == null)
                {
                    return NotFound($"Conta com ID {id} não encontrada.");
                }

                return Ok(account);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar conta com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Cria uma nova conta
        /// </summary>
        /// <param name="request">Dados da conta a ser criada</param>
        /// <returns>Conta criada</returns>
        /// <response code="201">Retorna a conta criada</response>
        /// <response code="400">Se os dados da conta forem inválidos</response>
        [HttpPost]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateAccount([FromBody] AccountCreateRequest request)
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
                    return BadRequest("O nome da conta é obrigatório.");
                }

                if (string.IsNullOrWhiteSpace(request.currency))
                {
                    return BadRequest("O email da conta é obrigatório.");
                }

                var account = await _accountsApi.CreateAccountAsync(request);
                return CreatedAtAction(nameof(GetAccount), new { id = account.id }, account);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar conta");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Atualiza uma conta existente
        /// </summary>
        /// <param name="id">ID da conta</param>
        /// <param name="request">Dados atualizados da conta</param>
        /// <returns>Conta atualizada</returns>
        /// <response code="200">Retorna a conta atualizada</response>
        /// <response code="400">Se os dados da conta forem inválidos</response>
        /// <response code="404">Se a conta não for encontrada</response>
        [HttpPut("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateAccount([Required] string id, [FromBody] AccountPatchRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Validações específicas de negócio
                if (string.IsNullOrWhiteSpace(request.id))
                {
                    return BadRequest("O nome da conta é obrigatório.");
                }


                var account = await _accountsApi.UpdateAccountAsync(id, request);
                return Ok(account);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao atualizar conta com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Deleta uma conta
        /// </summary>
        /// <param name="id">ID da conta</param>
        /// <returns>Sem conteúdo</returns>
        /// <response code="204">Se a conta for deletada com sucesso</response>
        /// <response code="404">Se a conta não for encontrada</response>
        [HttpDelete("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteAccount([Required] string id)
        {
            try
            {
                await _accountsApi.DeleteAccountAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar conta com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }
    }
} 