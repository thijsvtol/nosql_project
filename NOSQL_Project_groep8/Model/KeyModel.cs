using MongoDB.Bson;

namespace NOSQL_Project_groep8.Model
{
    public class KeyModel
    {
        public ObjectId _id { get; set; }
        public string Key { get; set; }
        public string Email { get; set; }
    }
}
