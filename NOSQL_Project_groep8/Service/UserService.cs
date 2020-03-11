using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //Hier komt de update/insert/delete methodes

        public void InsertUser(UserModel user)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            collection.InsertOne(user);
        }
    }
}