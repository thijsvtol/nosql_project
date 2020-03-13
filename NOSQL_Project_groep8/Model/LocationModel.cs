using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOSQL_Project_groep8.Model
{
    public class LocationModel
    {
        public ObjectId _id { get; set; }
        public string Location { get; set; }
    }
}
