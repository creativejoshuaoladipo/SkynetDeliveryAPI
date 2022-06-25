using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkynetDeliveryAPI.Models.Requests;
using SkynetDeliveryAPI.Models.Responses;

namespace SkynetDeliveryAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class OffersController : ControllerBase
    {
   
        [HttpPost]
        [Route("GetOffer")]
        public async Task<dynamic> GetOffer([FromBody] SkynetOfferRequest request)
        {
            var result = new SkynetOfferResponse { Amount = 10.0M };
            return await Task.FromResult(result);
        }

    }
}
