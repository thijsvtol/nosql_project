﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Controller;

namespace NOSQL_Project_groep8.View
{
    public partial class CreateIncidenetView : UserControl
    {
        CreateIncidentController createIncidenetController = new CreateIncidentController();
        UsersModel User;
        public CreateIncidenetView()
        {
            InitializeComponent();

            cbUsers.DataSource = GetUsers();
            cbUsers.ValueMember = "UserId";
            cbUsers.DisplayMember = "FirstName";

            var dataSource = new List<string>();
            dataSource.Add("open");
            dataSource.Add("close");
            cbStatus.DataSource = dataSource;

        }

        private void btnAddIncident_Click(object sender, EventArgs e)
        {
            IncidentsModel incidentModel = new IncidentsModel();
            incidentModel.User = ((UsersModel)cbUsers.SelectedItem).UserId;
            incidentModel.Subject = txtSubject.Text;
            incidentModel.DateDeadline = DateTime.Parse(dtpDeadlineDate.Text);
            incidentModel.DateCreated = DateTime.Now;
            incidentModel.Status = "open";
            Index parent = (Index)this.Parent;

            createIncidenetController.SaveIncident(parent,incidentModel);

        }

        private List<UsersModel> GetUsers()
        {

            return createIncidenetController.GetUsers();
        }

        public void CleanForm()
        {
            cbUsers.SelectedIndex = -1;
            txtSubject.Text = "";
            dtpDeadlineDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
