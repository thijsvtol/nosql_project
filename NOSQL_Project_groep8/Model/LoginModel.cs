using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace NOSQL_Project_groep8.Model
{
    public class LoginModel
    {
        public ObjectId _id { get; set; }

        public int LoginId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
    }
}
