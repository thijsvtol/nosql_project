using MongoDB.Driver;
using NOSQL_Project_groep8.Model;
using System.Linq;

namespace NOSQL_Project_groep8.Repositories
{
    class KeyRepository
    {
        private ConfigDB ConfigDB;
        public KeyRepository()
        {
            ConfigDB = new ConfigDB();
        }
        
        /// <summary>
        /// get keymodel bij Key and Email
        /// </summary>
        /// <param name="key"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public KeyModel GetKey(string key, string email)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<KeyModel>("ResetKey");
            var builder = Builders<KeyModel>.Filter;
            var filter = builder.Eq(x => x.Key, key) & builder.Eq(x => x.Email, email);
            return collection.Find(filter).FirstOrDefault();
        }

        /// <summary>
        /// checks if a key exist with an Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public KeyModel CheckKeyExistByEmail(string email)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<KeyModel>("ResetKey");
            var builder = Builders<KeyModel>.Filter;
            var filter = builder.Eq(x => x.Email, email);
            return collection.Find(filter).FirstOrDefault();
        }
    }
}
