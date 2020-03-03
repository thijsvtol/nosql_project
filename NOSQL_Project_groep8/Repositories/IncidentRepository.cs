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
    class IncidentRepository
    {
        private ConfigDB ConfigDB;
        public IncidentRepository()
        {
            ConfigDB = new ConfigDB();
        }

        public Boolean SetNewIncident(IncidentsModel incident)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentsModel>("Incidents");

            collection.InsertOne(incident);

            return true;
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
