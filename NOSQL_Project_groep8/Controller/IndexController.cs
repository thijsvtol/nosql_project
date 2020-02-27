﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Configuration;
using NOSQL_Project_groep8.Model;

namespace NOSQL_Project_groep8.Controller
{
    class IndexController
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["MongoDB"].ToString();

        //VOORBEELD VAN HET VERKRIJGEN VAN DATA UIT DATABASE, SELECT QUERYS PLAATSEN IN DE MAP REPOSITORYS EN INSERT/UPDATE/DELETE IN DE MAP SERVICE
        public string GetSampleData()
        {
            string s = "";
            //Make Client
            MongoClient dbClient = new MongoClient(_connectionString);
            //Select database
            var database = dbClient.GetDatabase("GardenGroup");
            //Select collection
            var collection = database.GetCollection<IncidentsModel>("Incidents");
            //Get results (select)
            var all = collection.Find(new BsonDocument());

            foreach (var i in all.ToEnumerable())
            {
                s += i.IncidentId + "\r\n";
            }
            return s;
        }
    }
}
