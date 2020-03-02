using MongoDB.Bson;
using MongoDB.Driver;
using NOSQL_Project_groep8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSQL_Project_groep8.Repositories
{
    class UserRepository
    {
        private ConfigDB ConfigDB;
        public UserRepository()
        {
            ConfigDB = new ConfigDB();
        }

        public UsersModel GetUserPasswordByName(String username)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UsersModel>("Users");
            //Count documents (select)
            var filter = Builders<UsersModel>.Filter.Eq(x => x.Username, username);
            var select = Builders<UsersModel>.Projection.Include(x => x.Password);
            UsersModel user = collection.Find(filter).FirstOrDefault();
            
            return user;
        }
    }
}
