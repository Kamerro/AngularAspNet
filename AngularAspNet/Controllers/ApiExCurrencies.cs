using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.ComponentModel;

namespace AngularAspNet.Controllers
{
    public class ApiExCurrencies : Controller
    {
        //Creating static HttpClient 
        private static readonly HttpClient client = new HttpClient();
       
            
    public async Task<IActionResult> Index()
    {
    HttpResponseMessage response = await client.GetAsync("https://api.exchangerate-api.com/v4/latest/USD");
    string responseBody = await response.Content.ReadAsStringAsync();
    //
    //Creating collection provided with NewtonsoftJson
    var data = JObject.Parse(responseBody);
            //st.WriteLine("1 USD is equal to " + data["rates"]["EUR"] + " Euros " + DateTime.Now.ToString());
            //st.WriteLine("1 USD is equal to " + data["rates"]["PLN"] + " PLN " + DateTime.Now.ToString());
            //st.WriteLine("1 USD is equal to " + data["rates"]["CHF"] + " CHF " + DateTime.Now.ToString());
     return View();
    }
  }
}
