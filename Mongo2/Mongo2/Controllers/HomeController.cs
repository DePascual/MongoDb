using Mongo2.Helpers;
using Mongo2.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace Mongo2.Controllers
{
    public class HomeController : Controller
    {
        private MDBContext _dbContext;
        public HomeController()
        {
            _dbContext = new MDBContext();
        }

        // GET: Home
        public ActionResult Index()
        {

            //var client = new MongoClient("mongodb://localhost:27017");
            //var database = client.GetDatabase("test");

            var collection = _dbContext.GetDatabase().GetCollection<usuario>("coleccion1");
            var q = collection.AsQueryable();

            List<usuario> usuariosList = q.AsQueryable().Select(r => r).ToList();

            //var all = collection.Find(usuario).ToList();
            //List<usuario> usuarioList = new List<usuario>();

            //foreach (var a in all)
            //{
            //    BsonSerializer.Deserialize<usuario>(a);
            //    usuario u = new usuario();
            //    u.id = a["_id"].AsObjectId;
            //    u.nombre = a["nombre"].AsString;
            //    u.apellido = a["apellido"].AsString;

            //    usuarioList.Add(u);
            //}


            TempData["listado"] = usuariosList;
            return View();
        }
    }
}