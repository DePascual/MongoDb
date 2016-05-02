using Mongo2.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mongo2.Controllers
{
    public class MDBContext
    {
        private MongoDatabase database;

        public MDBContext()
        {
            var client = new MongoClient("mongodb://localhost");
            var server = client.GetServer();
            this.database = server.GetDatabase("FitocracyDB_1");
        }


        public MongoDatabase GetDatabase()
        {
            return database;
        }


        //private IMongoDatabase _database;
        //public MDBContext()
        //{
        //    var client = new MongoClient("mongodb://localhost");
        //    this._database = client.GetDatabase("FitocracyDB_1");
        //}

        //public IMongoDatabase GetDatabase()
        //{
        //    return _database;
        //}
    }
}