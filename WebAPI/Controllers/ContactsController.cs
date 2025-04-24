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
    /// Controller para gerenciamento de contatos
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    [Produces("application/json")]
    public class ContactsController : ControllerBase
    {
        private readonly ContactsApi _contactsApi;
        private readonly ILogger<ContactsController> _logger;

        public ContactsController(ContactsApi contactsApi, ILogger<ContactsController> logger)
        {
            _contactsApi = contactsApi;
            _logger = logger;
        }

        /// <summary>
        /// Obtém todos os contatos com paginação
        /// </summary>
        /// <param name="page">Número da página (mínimo: 1)</param>
        /// <param name="pageSize">Tamanho da página (mínimo: 1, máximo: 100)</param>
        /// <returns>Lista de contatos</returns>
        /// <response code="200">Retorna a lista de contatos</response>
        /// <response code="400">Se os parâmetros forem inválidos</response>
        /// <response code="401">Se o usuário não estiver autenticado</response>
        /// <response code="403">Se o usuário não tiver permissão</response>
        [HttpGet]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> GetContacts(
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

                var contacts = await _contactsApi.GetContactsAsync();
                _logger.LogInformation($"Retornando {contacts.data.Count} contatos da página {page}");
                return Ok(contacts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar contatos");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Obtém um contato específico pelo ID
        /// </summary>
        /// <param name="id">ID do contato</param>
        /// <returns>Dados do contato</returns>
        /// <response code="200">Retorna o contato solicitado</response>
        /// <response code="400">Se o ID for inválido</response>
        /// <response code="404">Se o contato não for encontrado</response>
        [HttpGet("{id}")]
        [Authorize(Policy = "UserOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetContact([Required] string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    return BadRequest("ID do contato é obrigatório.");
                }

                var contact = await _contactsApi.GetContactAsync(id);
                if (contact == null)
                {
                    return NotFound($"Contato com ID {id} não encontrado.");
                }

                return Ok(contact);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao buscar contato com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Cria um novo contato
        /// </summary>
        /// <param name="request">Dados do contato a ser criado</param>
        /// <returns>Contato criado</returns>
        /// <response code="201">Retorna o contato criado</response>
        /// <response code="400">Se os dados do contato forem inválidos</response>
        [HttpPost]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateContact([FromBody] ContactCreateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                // Validações específicas de negócio
                if (string.IsNullOrWhiteSpace(request.first_name))
                {
                    return BadRequest("O nome é obrigatório.");
                }

                if (string.IsNullOrWhiteSpace(request.last_name))
                {
                    return BadRequest("O sobrenome é obrigatório.");
                }

                if (string.IsNullOrWhiteSpace(request.account_id) && string.IsNullOrWhiteSpace(request.account_number))
                {
                    return BadRequest("O ID da conta ou número da conta é obrigatório.");
                }

                var contact = await _contactsApi.CreateContactAsync(request);
                return CreatedAtAction(nameof(GetContact), new { id = contact.id }, contact);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar contato");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Atualiza um contato existente
        /// </summary>
        /// <param name="id">ID do contato</param>
        /// <param name="request">Dados atualizados do contato</param>
        /// <returns>Contato atualizado</returns>
        /// <response code="200">Retorna o contato atualizado</response>
        /// <response code="400">Se os dados do contato forem inválidos</response>
        /// <response code="404">Se o contato não for encontrado</response>
        [HttpPut("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateContact([Required] string id, [FromBody] ContactPatchRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var contact = await _contactsApi.UpdateContactAsync(id, request);
                return Ok(contact);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao atualizar contato com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }

        /// <summary>
        /// Deleta um contato
        /// </summary>
        /// <param name="id">ID do contato</param>
        /// <returns>Sem conteúdo</returns>
        /// <response code="204">Se o contato for deletado com sucesso</response>
        /// <response code="404">Se o contato não for encontrado</response>
        [HttpDelete("{id}")]
        [Authorize(Policy = "AdminOnly")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteContact([Required] string id)
        {
            try
            {
                await _contactsApi.DeleteContactAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar contato com ID {id}");
                return StatusCode(500, "Ocorreu um erro ao processar sua solicitação.");
            }
        }
    }
} 