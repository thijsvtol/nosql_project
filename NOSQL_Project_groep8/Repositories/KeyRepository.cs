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
        
        public KeyModel GetKey(string key)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<KeyModel>("ResetKey");
            var builder = Builders<KeyModel>.Filter;
            var filter = builder.Eq(x => x.Key, key);
            return collection.Find(filter).FirstOrDefault();
        }

        public KeyModel GetKeyByEmail(string email)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<KeyModel>("ResetKey");
            var builder = Builders<KeyModel>.Filter;
            var filter = builder.Eq(x => x.Email, email);
            return collection.Find(filter).FirstOrDefault();
        }
    }
}
