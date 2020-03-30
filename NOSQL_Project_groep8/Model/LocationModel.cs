using MongoDB.Bson;

namespace NOSQL_Project_groep8.Model
{
    public class LocationModel
    {
        public ObjectId _id { get; set; }
        public string Location { get; set; }
    }
}
