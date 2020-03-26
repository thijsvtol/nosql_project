using MongoDB.Driver;
using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSQL_Project_groep8.Service
{
    class KeyService
    {
        private ConfigDB ConfigDB;
        public KeyService()
        {
            ConfigDB = new ConfigDB();
        }

        /// <summary>
        /// set new key with email and key in the DB
        /// </summary>
        /// <param name="key"></param>
        /// <param name="email"></param>
        public void SetKey(string key, string email)
        {
            KeyModel keyModel = new KeyModel() { Email = email, Key = key };
            var collection = ConfigDB.GetDatabase().GetCollection<KeyModel>("ResetKey");

            collection.InsertOne(keyModel);
        }

        /// <summary>
        /// Deletes the key when password is changed
        /// </summary>
        /// <param name="key"></param>
        public void DeleteKey(string key)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<KeyModel>("ResetKey");
            var builder = Builders<KeyModel>.Filter;
            var filter = builder.Eq(x => x.Key, key);
            collection.DeleteOne(filter);
        }

        /// <summary>
        /// Update key to a new key by existing email
        /// </summary>
        /// <param name="keyModel"></param>
        public void UpdateKey(KeyModel keyModel)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<KeyModel>("ResetKey");
            var builder = Builders<KeyModel>.Filter;
            var filter = builder.Eq(x => x.Email, keyModel.Email);
            collection.ReplaceOne(filter, keyModel);
        }
    }
}
