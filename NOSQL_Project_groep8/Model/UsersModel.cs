using MongoDB.Bson;

namespace NOSQL_Project_groep8.Model
{
    public class UsersModel
    {
        public ObjectId _id { get; set; }

        public int UserId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
