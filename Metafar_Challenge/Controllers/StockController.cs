using Metafar_Challenge.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Metafar_Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly string basepath = "https://api.twelvedata.com";

        public StockController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet]
        public async Task<ActionResult> Get(string symbol)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, basepath + "/stocks?symbol="+ symbol +"&source=docs");
            var client = _clientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStreamAsync();
                var data = await JsonSerializer.DeserializeAsync<TwelvedataSample>(responseStream);

                return Ok(data); // Send the data as the response
            }
            else
            {
                return StatusCode((int)response.StatusCode, $"Error occurred while calling API. Status code : {response.StatusCode}");
            }
        }
    }
}