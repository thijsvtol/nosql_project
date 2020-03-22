﻿using System;
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

        public void InsertUser(UserModel user)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            collection.InsertOne(user);
        }

        public void InsertMany(List<UserModel> list)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<UserModel>("Users");
            collection.InsertMany(list);
        }
    }
}