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
        private bool usuNuevo;
        private IMongoDatabase _database;
        public MDBContext()
        {
            var client = new MongoClient("mongodb://localhost");
            this._database = client.GetDatabase("FitocracyDB_1");
        }

        public IMongoDatabase GetDatabase()
        {
            return _database;
        }


        public bool insert(usuario usuario)
        {
            var collection = GetDatabase().GetCollection<usuario>("usuarios");
            collection.InsertOne(usuario);

            return !String.IsNullOrEmpty(usuario._id.ToString());
        }

        public void numSeq()
        {
            var collection = GetDatabase().GetCollection<usuario>("usuarios");

            var result = collection.FindOneAndReplace(new FindAndModifyArgs()
            {
                

            })





            var num = collection.AsQueryable().Where(r => r._id == "userid").Select(q => q);
        }

    }
}