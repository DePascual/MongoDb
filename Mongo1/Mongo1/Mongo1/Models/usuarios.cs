using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mongo1.Models
{
    public class usuarios
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
    }
}