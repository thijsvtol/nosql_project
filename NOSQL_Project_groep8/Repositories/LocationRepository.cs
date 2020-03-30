using MongoDB.Driver;
using NOSQL_Project_groep8.Model;
using System.Collections.Generic;
using System.Linq;

namespace NOSQL_Project_groep8.Repositories
{
    public class LocationRepository
    {
        private ConfigDB ConfigDB;
        public LocationRepository()
        {
            ConfigDB = new ConfigDB();
        }

        /// <summary>
        /// Get all locations that exist in the DB
        /// </summary>
        /// <returns></returns>
        public List<LocationModel> GetAllLocations()
        {
            //Select collection
            var collection = ConfigDB.GetDatabase().GetCollection<LocationModel>("Location");
            List<LocationModel> Locations = collection.Find(Builders<LocationModel>.Filter.Empty).ToList();
            return Locations;
        }
    }
}
