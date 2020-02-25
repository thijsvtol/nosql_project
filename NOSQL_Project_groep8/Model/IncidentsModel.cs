﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace NOSQL_Project_groep8.Model
{
    public class IncidentsModel
    {
        public ObjectId _id { get; set; }

        public int IncidentId { get; set; }

        public string Subject { get; set; }

        public int User { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateSolved { get; set; }

        public string Status { get; set; }
    }
}
