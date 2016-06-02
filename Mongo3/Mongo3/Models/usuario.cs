using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mongo3.Models
{
    public class usuario
    {
        public ObjectId _id { get; set; }
        public string _nombre { get; set; }
        public string _apellido1 { get; set; }
        public string _apellido2 { get; set; }
        public byte[] _foto { get; set; }
    }
}