﻿using System;
using MongoDB.Bson;

namespace NOSQL_Project_groep8.Model
{
    public class IncidentModel
    {
        public ObjectId _id { get; set; }
        public int IncidentId { get; set; }
        public string Subject { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateDeadline { get; set; }
        public DateTime DateSolved { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int CreatedUserId { get; set; }
    }
}