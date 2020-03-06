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

        public UserModel GetUserPasswordByName(String username)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            //Count documents (select)
            var filter = Builders<UserModel>.Filter.Eq(x => x.Username, username);
            var select = Builders<UserModel>.Projection.Include(x => x.Password);
            UserModel user = collection.Find(filter).FirstOrDefault();
            
            return user;
        }

        public UserModel GetUserPasswordByEmail(String email)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            //Count documents (select)
            var filter = Builders<UserModel>.Filter.Eq(x => x.Email, email);
            UserModel user = collection.Find(filter).FirstOrDefault();

            return user;
        }

        public void ChangePassword(UserModel user)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            var builder = Builders<UserModel>.Filter;
            var filter = builder.Eq(x => x.Email, user.Email);
            collection.ReplaceOne(filter, user);

        }
        public List<UserModel> GetAllUsers()
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            List<UserModel> users = collection.Find(Builders<UserModel>.Filter.Empty).ToList();

            return users;
        }

        public int AutoIncredement()
        {
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            var sort = Builders<UserModel>.Sort.Descending(x => x.UserId);
            var filter = Builders<UserModel>.Filter.Empty;
            UserModel user = collection.Find(filter).Sort(sort).Limit(1).FirstOrDefault();
            return user.UserId + 1;
        }
    }
}
