using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mongo2.Controllers
{
    public class MDBContext
    {
        private IMongoDatabase _database;

        public MDBContext()
        {
            var client = new MongoClient("mongodb://localhost");
            this._database = client.GetDatabase("test");
        }

        public IMongoDatabase GetDatabase()
        {
            return _database;
        }
    }
}