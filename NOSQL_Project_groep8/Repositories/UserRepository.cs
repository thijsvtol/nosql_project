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

        public UsersModel GetUserPasswordByEmail(String email)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UsersModel>("Users");
            //Count documents (select)
            var filter = Builders<UsersModel>.Filter.Eq(x => x.Email, email);
            UsersModel user = collection.Find(filter).FirstOrDefault();

            return user;
        }

        public void ChangePassword(UsersModel user)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<UsersModel>("Users");
            var builder = Builders<UsersModel>.Filter;
            var filter = builder.Eq(x => x.Email, user.Email);
            collection.ReplaceOne(filter, user);

        }
        public List<UsersModel> GetAllUsers()
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UsersModel>("Users");
            List<UsersModel> users = collection.Find(Builders<UsersModel>.Filter.Empty).ToList();

            return users;
        }
    }
}
