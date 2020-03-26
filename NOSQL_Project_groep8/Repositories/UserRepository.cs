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

        /// <summary>
        /// Get user by Username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public UserModel GetUser(string username)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            //Count documents (select)
            var filter = Builders<UserModel>.Filter.Eq(x => x.Username, username);
            var select = Builders<UserModel>.Projection.Include(x => x.Password);
            UserModel user = collection.Find(filter).FirstOrDefault();
           
            return user;
        }

        /// <summary>
        /// Checks if user exists with the right username and password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckUser(string username, string password)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            //Count documents (select)
            var filter = Builders<UserModel>.Filter.Eq(x => x.Username, username) & Builders<UserModel>.Filter.Eq(x => x.Password, password);
            var select = Builders<UserModel>.Projection.Include(x => x.Password);
            UserModel user = collection.Find(filter).FirstOrDefault();
            if(user != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get user by an Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public UserModel GetUserPasswordByEmail(String email)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            //Count documents (select)
            var filter = Builders<UserModel>.Filter.Eq(x => x.Email, email);
            UserModel user = collection.Find(filter).FirstOrDefault();

            return user;
        }

        public void ChangeRole(UserModel user)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            var update = Builders<UserModel>.Update.Set(x => x.TypeOfUser, user.TypeOfUser);
            collection.UpdateOne(x => x.UserId == user.UserId, update);

        }

        public void DeleteUser(UserModel user)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            collection.DeleteOne(x => x.UserId == user.UserId);

        }

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        public List<UserModel> GetAllUsers()
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            List<UserModel> users = collection.Find(Builders<UserModel>.Filter.Empty).ToList();

            return users;
        }

        /// <summary>
        /// Gets the last Id of the Userlist
        /// </summary>
        /// <returns></returns>
        public int AutoIncredement()
        {
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            var sort = Builders<UserModel>.Sort.Descending(x => x.UserId);
            var filter = Builders<UserModel>.Filter.Empty;
            UserModel user = collection.Find(filter).Sort(sort).Limit(1).FirstOrDefault();
            return user.UserId + 1;
        }

        /// <summary>
        /// Get the count of al the users in the DB
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public int CountExcistingUsers(string username, string email)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            //Count documents (select)
            var filter = Builders<UserModel>.Filter.Eq(x => x.Username, username) | Builders<UserModel>.Filter.Eq(x => x.Email, email);
            double count = collection.CountDocuments(filter);
            return Convert.ToInt32(count);
        }

        /// <summary>
        /// Checks if a user exists with the email and favorite Color
        /// </summary>
        /// <param name="favColor"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool CheckFavColor(string favColor, string email)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            //Count documents (select)
            var filter = Builders<UserModel>.Filter.Eq(x => x.FavColor, favColor) & Builders<UserModel>.Filter.Eq(x => x.Email, email);
            UserModel user = collection.Find(filter).FirstOrDefault();

            if (user != null) return true;
            return false;
        }
    }
}
