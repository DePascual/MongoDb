using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mongo1.Controllers
{
    public class DefaultController : Controller
    {
        public DefaultController()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("test");
        }


        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}