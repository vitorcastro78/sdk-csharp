using Microsoft.AspNetCore.Mvc;
using Zuora.Api;

namespace Zuora.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubscriptionsController : ControllerBase
    {
        private readonly SubscriptionsApi _subscriptionsApi;

        public SubscriptionsController(SubscriptionsApi subscriptionsApi)
        {
            _subscriptionsApi = subscriptionsApi;
        }

        [HttpGet]
        public async Task<IActionResult> GetSubscriptions()
        {
            try
            {
                var subscriptions = await _subscriptionsApi.GetSubscriptionsAsync();
                return Ok(subscriptions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao buscar assinaturas: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubscription(string id)
        {
            try
            {
                var subscription =  _subscriptionsApi.GetSubscriptionByKey(id);
                return Ok(subscription);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Erro ao buscar assinatura: {ex.Message}");
            }
        }
    }
} 