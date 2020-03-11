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

        public void SetKey(string key, string email)
        {
            KeyModel keyModel = new KeyModel() { Email = email, Key = key };
            var collection = ConfigDB.GetDatabase().GetCollection<KeyModel>("ResetKey");

            collection.InsertOne(keyModel);
        }

        public void DeleteKey(string key)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<KeyModel>("ResetKey");
            var builder = Builders<KeyModel>.Filter;
            var filter = builder.Eq(x => x.Key, key);
            collection.DeleteOne(filter);
        }

        public void UpdateKey(KeyModel keyModel)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<KeyModel>("ResetKey");
            var builder = Builders<KeyModel>.Filter;
            var filter = builder.Eq(x => x.Email, keyModel.Email);
            collection.ReplaceOne(filter, keyModel);
        }
    }
}
