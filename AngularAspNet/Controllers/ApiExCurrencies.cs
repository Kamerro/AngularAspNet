using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.ComponentModel;

namespace AngularAspNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiExCurrenciesController : Controller
    {
        //Creating static HttpClient 
        private static readonly HttpClient client = new HttpClient();


        public ApiExCurrenciesController()
        {

        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            HttpResponseMessage response = await client.GetAsync("https://api.exchangerate-api.com/v4/latest/USD");
            string responseBody = await response.Content.ReadAsStringAsync();
            var data = JObject.Parse(responseBody);
            var eur = data["rates"]["Eur"];

            return "dupa";
        }
  }
}
