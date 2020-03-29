using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace NOSQL_Project_groep8.Service
{
    class IncidentService
    {
        private ConfigDB ConfigDB;

        public IncidentService()
        {
            ConfigDB = new ConfigDB();
        }

        // Creates new incident
        public Boolean SetNewIncident(IncidentModel incident)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            collection.InsertOne(incident);
            return true;
        }

        //insert list
        public void InsertIncidentModelList(List<IncidentModel> list)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            collection.InsertMany(list);
        }

        //delete incident
        public void DeleteIncident(IncidentModel incident)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            collection.DeleteOne(x => x.IncidentId == incident.IncidentId);

        }
    }
}