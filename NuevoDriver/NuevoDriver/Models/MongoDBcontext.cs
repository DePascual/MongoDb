using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace NuevoDriver.Models
{
    public class MongoDBcontext
    {
        public const string CONNECTION_STRING_NAME = "mongodb://Tpg17pT9vKIqVbqze4zKltGiQ1fcC/a36ZLWMPnYQLk=@ds017582.mlab.com:17582/fitocracymdb";
        public const string DATABASE_NAME = "fitocracymdb";
        public const string USUARIOS_COLLECTION_NAME = "usuarios";
        public const string ENTRENADORES_COLLECTION_NAME = "entrenadores";

        private static readonly IMongoClient _client;
        private static readonly IMongoDatabase _database;

        static MongoDBcontext()
        {
            var credencialesOK = desencriptaConnectionString();
            var nuevaConexion = "mongodb://" + credencialesOK + "@ds017582.mlab.com:17582/fitocracymdb";

            //var connectionString = ConfigurationManager.ConnectionStrings[nuevaConexion].ConnectionString;
            _client = new MongoClient(nuevaConexion);
            _database = _client.GetDatabase(DATABASE_NAME);
        }

        public IMongoClient Client
        {
            get { return _client; }
        }

        public IMongoDatabase getDatabase
        {
            get { return _database; }
        }


        public IMongoCollection<Usuario> Users
        {
            get { return _database.GetCollection<Usuario>(USUARIOS_COLLECTION_NAME); }
        }




        private static string desencriptaConnectionString()
        {
            var uriEncriptada = CONNECTION_STRING_NAME;
            EncriptacionClass encryt = new EncriptacionClass();
            var credencialesEncriptadas = uriEncriptada.Split(new[] { '@' })[0].Split(new[] { "mongodb://" }, StringSplitOptions.None)[1];
            string credencialesOK = encryt.Desencrit(credencialesEncriptadas);
            return credencialesOK;
        }
    }
}