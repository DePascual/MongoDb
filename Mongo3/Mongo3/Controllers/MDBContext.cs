using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mongo3.Controllers
{
    public class MDBContext
    {
        private const string connectionString = "mongodb://localhost";
        private const string databaseName = "FitocracyDB_1";
        //private const string collectionName = "team";

        private MongoClient client { get; set; }
        protected MongoServer server { get; set; }
        protected MongoDatabase database { get; set; }
        protected MongoCollection<Type> collection { get; set; }
        protected MongoCollection<BsonDocument> documentCollection { get; set; }


        public MDBContext()
        {
            client = new MongoClient(connectionString);
            server = client.GetServer();
            database = server.GetDatabase(databaseName);
        }


        public MongoDatabase GetDatabase()
        {
            return database;
        }


        //public MongoCollection<Type> GetCollection(Type tipo, string collectionName)
        //{
        //    return database.GetCollection<Type>(collectionName);
            
        //}


        //protected virtual void PopulateDatabase()
        //{
        //    // create some entries 
        //    var developer = new Developer(1, "Test", "Person", "Developer");
        //    collection.Insert(developer);
        //    var developer2 = new Developer(2, "Another", "Developer", "Developer");
        //    collection.Insert(developer2);

        //    BsonDocument document = new BsonDocument();
        //    document.Add(new BsonElement("name", "Testing"))
        //        .Add(new BsonElement("number", new BsonInt32(42)));

        //    documentCollection.Insert(document);
        //    var documentId = document["_id"];
        //}
    }
}