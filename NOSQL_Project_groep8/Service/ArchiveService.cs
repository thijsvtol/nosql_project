using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using System;

namespace NOSQL_Project_groep8.Service
{
    class ArchiveService
    {
        private ConfigDB ConfigDB;

        public ArchiveService()
        {
            ConfigDB = new ConfigDB();
        }

        //archiveer incident in ander collection
        public Boolean ArchiveIncident(IncidentModel incident)
        {
            var collection = ConfigDB.GetDatabase().GetCollection<IncidentModel>("Archive");
            collection.InsertOne(incident);
            return true;
        }
    }
}