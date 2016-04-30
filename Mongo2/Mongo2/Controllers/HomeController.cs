using Mongo2.Helpers;
using Mongo2.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
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
           
            var collection = _dbContext.GetDatabase().GetCollection<usuario>("usuarios");

            //Usuario Nuevo
            var usuNuevo = new usuario();
            usuNuevo._nombre = "Carolina";
            usuNuevo._apellido1 = "Pascual"; 
            usuNuevo._apellido2 = "Jimenez";

            //Se inserta el usuario
            collection.InsertOne(usuNuevo);

            //Recuperar usuarios con LINQ
            var query =
                from e in collection.AsQueryable()
                select e;

            List<usuario> usus = new List<usuario>();

            foreach (var usu in query)
            {
                usus.Add(usu);
            }


            //Recuperar usuarios con lambda
            List<usuario> usus2 = collection.AsQueryable().Select(x => x).ToList();

            TempData["listado"] = usus;
            TempData["listado2"] = usus2;
            return View();
        }
    }
}