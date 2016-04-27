using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mongo2.Models
{
    public class usuario
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
    }
}