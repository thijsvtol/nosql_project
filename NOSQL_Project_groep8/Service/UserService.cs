using System.Collections.Generic;
using MongoDB.Driver;
using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;

namespace NOSQL_Project_groep8.Service
{
    class UserService
    {
        private ConfigDB ConfigDB;

        public UserService()
        {
            ConfigDB = new ConfigDB();
        }

        //Insert single user
        public void InsertUser(UserModel user)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            collection.InsertOne(user);
        }

        //Insert many users
        public void InsertUserModelList(List<UserModel> list)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            collection.InsertMany(list);
        }
        
        //Change user his password
        public void ChangePassword(UserModel user)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            var builder = Builders<UserModel>.Filter;
            var filter = builder.Eq(x => x.Email, user.Email);
            collection.ReplaceOne(filter, user);
        }

        public void UpdateUser(UserModel user)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            var builder = Builders<UserModel>.Filter;
            var filter = builder.Eq(x => x.UserId, user.UserId);
            collection.ReplaceOne(filter, user);
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
    }
}