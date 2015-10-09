using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
namespace ClientAuth.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();

            string authInfo = "admin" + ":" + "123456";
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authInfo);

            client.BaseAddress = new Uri("http://localhost:1810/");

            HttpResponseMessage response = client.GetAsync("api/Filial/673b5bfd-396e-4179-8g52-1f5d97aba3bd").Result;
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                //var data = response.Content.ReadAsAsync>().Result;
                return View();
            }
            return View();
        }
    }
}