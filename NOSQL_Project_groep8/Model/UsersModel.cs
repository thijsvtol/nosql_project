using MongoDB.Bson;

namespace NOSQL_Project_groep8.Model
{
    public class UsersModel
    {
        public ObjectId _id { get; set; }

        public int UserId { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phonenumber { get; set; }

        public string TypeOfUser { get; set; }

        public string Location { get; set; }
    }
}
