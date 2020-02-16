using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MongoDB.Driver;
using MongoDB.Bson;

namespace NOSQL_Project_groep8
{
    public partial class Form1 : Form
    {
        //Connection string
        private static string _connectionString = ConfigurationManager.ConnectionStrings["MongoDB"].ToString();

        public Form1()
        {
            InitializeComponent();
            label1.Text = null;
            //Make Client
            MongoClient dbClient = new MongoClient(_connectionString);
            //Select database
            var database = dbClient.GetDatabase("sample_analytics");
            //Select collection
            var collection = database.GetCollection<Entity>("accounts");
            //Get results (select)
            var all = collection.Find(new BsonDocument());

            foreach (var i in all.ToEnumerable())
            {
                label1.Text += i.account_id.ToString() + "\r\n";
            }
        }
    }

    public class Entity
    {
        public ObjectId Id { get; set; }

        public int account_id { get; set; }

        public int limit { get; set; }

        public string[] products { get; set; }
    }
}
