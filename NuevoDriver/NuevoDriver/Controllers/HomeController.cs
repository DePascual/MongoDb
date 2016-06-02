using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NuevoDriver.Models;
using MongoDB.Driver;

namespace NuevoDriver.Controllers
{
    public class HomeController : Controller
    {

        private MongoDBcontext _dbContext;
        public HomeController()
        {
            _dbContext = new MongoDBcontext();
        }

        // GET: Home
        public ActionResult Index()
        {
            Usuario usu = new Usuario();
            usu = _dbContext.Users.Find<Usuario>(x => x._id == "574ad4ea29d0471c4867b0c6").SingleOrDefault();

            return View(usu);
        }
    }
}