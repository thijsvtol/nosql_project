using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSQL_Project_groep8.Service
{
    class IncidentService
    {
        private ConfigDB ConfigDB;
        public IncidentService()
        {
            ConfigDB = new ConfigDB();
        }

        public Boolean SetNewIncident(IncidentModel incident)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            collection.InsertOne(incident);
            return true;
        }

        public void InsertMany(List<IncidentModel> list)
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Incidents");
            collection.InsertMany(list);
        }
    }
}
