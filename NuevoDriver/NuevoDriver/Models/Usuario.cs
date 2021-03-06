﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuevoDriver.Models
{
    public class Usuario
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        private string _Email;

        private string _Username;

        private string _Password;

        private byte[] _Foto;

        private int _Points;

        private int _Age;

        private string _Description;

        private int _Level;

        private Dictionary<string, Workouts> _WorkoutsUser;

        private Dictionary<string, Dictionary<string, int>> _EvolutionUser;

        private Dictionary<string, Workouts> _CustomWorkouts;

        private DateTime _Birthday;

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string Username
        {
            get
            {
                return _Username;
            }

            set
            {
                _Username = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }

        public byte[] Foto
        {
            get
            {
                return _Foto;
            }

            set
            {
                _Foto = value;
            }
        }

        public int Points
        {
            get
            {
                return _Points;
            }

            set
            {
                _Points = value;
            }
        }

        public int Age
        {
            get
            {
                return _Age;
            }

            set
            {
                _Age = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }

            set
            {
                _Description = value;
            }
        }

        public int Level
        {
            get
            {
                return _Level;
            }

            set
            {
                _Level = value;
            }
        }


        public DateTime Birthday
        {
            get
            {
                return _Birthday;
            }

            set
            {
                _Birthday = value;
            }
        }

        public Dictionary<string, Workouts> WorkoutsUser
        {
            get
            {
                return _WorkoutsUser;
            }

            set
            {
                _WorkoutsUser = value;
            }
        }

        public Dictionary<string, Dictionary<string, int>> EvolutionUser
        {
            get
            {
                return _EvolutionUser;
            }

            set
            {
                _EvolutionUser = value;
            }
        }

        public Dictionary<string, Workouts> CustomWorkouts
        {
            get
            {
                return _CustomWorkouts;
            }

            set
            {
                _CustomWorkouts = value;
            }
        }

        public Usuario usuarioById(string id)
        {
            try
            {
                MongoDBcontext _dbContext = new MongoDBcontext();

                var collection = _dbContext.Users;
                //var document = collection.Find(new BsonDocument()).FirstOrDefaultAsync();
                var doc = collection.Find<Usuario>(x => x._id == id).SingleOrDefault();
                return doc;

                //var collection = _dbContext.GetDatabase().GetCollection<Usuario>("usuarios");
                //return collection.AsQueryable().Where(x => x._id == id).Select(x => (Usuario)x).SingleOrDefault();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}