using Mongo3.Models;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mongo3.Controllers
{
    public class HomeController : Controller
    {

        private MDBContext _dbContext;
        public HomeController()
        {
            _dbContext = new MDBContext();
        }

        private byte[] ImgToDb(FileInfo info)
        {
            byte[] content = new byte[info.Length];
            FileStream imagestream = info.OpenRead();
            imagestream.Read(content, 0, content.Length);
            imagestream.Close();
            return content;
        }

        // GET: Home
        public ActionResult Index()
        {
            var usuNuevo = new usuario();
            usuNuevo._nombre = "Carolina";
            usuNuevo._apellido1 = "Pascual";
            usuNuevo._apellido2 = "Jimenez";
            usuNuevo._foto = ImgToDb(new FileInfo(Server.MapPath("~//Content//Imagenes//portada.jpg")));


            return View();
        }

        public ActionResult downloadPhoto()
        {
            var collection = _dbContext.GetDatabase().GetCollection<usuario>("usuarios");

            var query = Query<usuario>.EQ(p => p._nombre, "Carolina");
            var img = collection.Find(query).Select(r => r._foto);

            return File(img, "image/jpg");
        }
    }
}