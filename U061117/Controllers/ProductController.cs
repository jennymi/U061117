using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;
using U061117.Models;

namespace U061117.Controllers
{
    public class ProductController : ApiController
    {
        private List<Product> prod = new List<Product>();

        public ProductController()
        {
            prod.Add(new Product() { Name = "Thailand", Event = "Dans", Place = "Östra gymnasiet", Time = "2017-10-24 kl 14:00", Id = 10 });
            prod.Add(new Product() { Name = "Thailand", Event = "Dans", Place = "Östra gymnasiet", Time = "2017-10-24 kl 14:00", Id = 20 });
            prod.Add(new Product() { Name = "Tyskland", Event = "Dans", Place = "Östra gymnasiet", Time = "2017-10-24 kl 14:00", Id = 30 });
            prod.Add(new Product() { Name = "Thailand", Event = "Dans", Place = "Östra gymnasiet", Time = "2017-10-24 kl 14:00", Id = 40 });
            prod.Add(new Product() { Name = "Thailand", Event = "Dans", Place = "Östra gymnasiet", Time = "2017-10-24 kl 14:00", Id = 50 });
        }

        [HttpGet]
        public List<Product> Products()
        {
            return prod;
        }
    }
}
