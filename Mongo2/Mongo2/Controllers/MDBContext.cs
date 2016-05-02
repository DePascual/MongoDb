using Mongo2.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core;
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
            var uri = "mongodb://DePascual:Magarza22@ds011880.mlab.com:11880/pimerapruebacarol";
            var client = new MongoClient(uri);
            var server = client.GetServer();
            this.database = server.GetDatabase("pimerapruebacarol");
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