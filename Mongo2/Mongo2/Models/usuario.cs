using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mongo2.Models
{

    public class usuario
    {
        //[BsonConstructor]
        //public usuario(int usuarioId, string nombre, string apellido1, string apellido2)
        //{
        //    _usuarioId = usuarioId;
        //    _nombre = nombre;
        //    _apellido1 = apellido1;
        //    _apellido2 = apellido2;
        //}

        public ObjectId _id { get; set; }
        public string _nombre { get; set; }
        public string _apellido1 { get; set; }
        public string _apellido2 { get; set; }


    }
}