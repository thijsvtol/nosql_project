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
    public class LocationRepository
    {
        private ConfigDB ConfigDB;
        public LocationRepository()
        {
            ConfigDB = new ConfigDB();
        }

        public List<LocationModel> GetAllLocations()
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<LocationModel>("Location");
            List<LocationModel> Locations = collection.Find(Builders<LocationModel>.Filter.Empty).ToList();

            return Locations;
        }
    }
}
