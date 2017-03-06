using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using DemoWebMVCApp.Models;
using Newtonsoft.Json;

namespace DemoWebMVCApp.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand
        public ActionResult Index()
        {
            string url = "http://localhost:52677/";
            List<Brands> brand = new List<Brands>();

            HttpClient client = new HttpClient(); //obj to handle requests and responses
            client.BaseAddress = new Uri(url);

            var mediaType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(mediaType);
            HttpResponseMessage response = client.GetAsync("api/brands/").Result;

            if(response.IsSuccessStatusCode)
            {
                var obj = response.Content.ReadAsStringAsync().Result;
                brand = JsonConvert.DeserializeObject<List<Brands>>(obj);
            }

            return View();
        }
    }
}