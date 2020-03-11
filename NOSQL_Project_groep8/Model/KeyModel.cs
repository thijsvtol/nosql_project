using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSQL_Project_groep8.Model
{
    public class KeyModel
    {
        public ObjectId _id { get; set; }
        public string Key { get; set; }
        public string Email { get; set; }
    }
}
