using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace NOSQL_Project_groep8.Model
{
    public class IndexModel
    {
        public ObjectId Id { get; set; }

        public int account_id { get; set; }

        public int limit { get; set; }

        public string[] products { get; set; }
    }
}
