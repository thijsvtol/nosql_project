using MongoDB.Driver;
using NOSQL_Project_groep8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSQL_Project_groep8.Repositories
{
    class KeyRepository
    {
        private ConfigDB ConfigDB;
        public KeyRepository()
        {
            ConfigDB = new ConfigDB();
        }

        public void SetKey(string key, string email)
        {
            KeyModel keyModel = new KeyModel(){ Email = email, Key = key };
            var collection = ConfigDB.GetDatabase().GetCollection<KeyModel>("ResetKey");

            collection.InsertOne(keyModel);
        }

        public KeyModel GetKey(string key)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<KeyModel>("ResetKey");
            var builder = Builders<KeyModel>.Filter;
            var filter = builder.Eq(x => x.Key, key);
            return collection.Find(filter).FirstOrDefault();
        }

        public void DeleteKey(string key)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<KeyModel>("ResetKey");
            var builder = Builders<KeyModel>.Filter;
            var filter = builder.Eq(x => x.Key, key);
            collection.DeleteOne(filter);
        }
    }
}
