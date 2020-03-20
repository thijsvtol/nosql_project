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
        CreateIncidentController CreateIncidentController = new CreateIncidentController();

        public CreateIncidenetView()
        {
            InitializeComponent();

            // set all dropdowns with rows
            cbUsers.DataSource = CreateIncidentController.GetUsers();
            cbUsers.ValueMember = "UserId";
            cbUsers.DisplayMember = "FirstName";

            cbLocation.DataSource = CreateIncidentController.GetLocation();
            cbLocation.DisplayMember = "Location";
            cbStatus.DataSource = CreateIncidentController.GetStatus();
            cbType.DataSource = CreateIncidentController.GetType();
            cbPriority.DataSource = CreateIncidentController.GetPriority();
            cb_deadlineFollowUp.DataSource = CreateIncidentController.GetDeadlineDates();
        }

        /// <summary>
        /// reset all fields
        /// </summary>
        public void CleanForm()
        {
            cbUsers.SelectedIndex = -1;
            txtSubject.Text = "";
            cb_deadlineFollowUp.SelectedIndex = -1;
        }

        private void btnAddIncident_Click(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            var dateDeadline = new DateTime();
            //checks for if it is a day or month 
            var deadLineDate = (ComboboxItem)cb_deadlineFollowUp.SelectedValue;
            if (deadLineDate.Type == "day")
            {
                dateDeadline = DateTime.Today.AddDays((cb_deadlineFollowUp.SelectedItem as ComboboxItem).Value);
            }
            else if ((cb_deadlineFollowUp.SelectedItem as ComboboxItem).Type == "month")
            {
                dateDeadline = DateTime.Today.AddMonths((cb_deadlineFollowUp.SelectedItem as ComboboxItem).Value);
            }

            //fills the model with all the info from the form
            IncidentModel incident = new IncidentModel()
            {
                UserId = ((UserModel)cbUsers.SelectedItem).UserId,
                Subject = txtSubject.Text,
                DateCreated = DateTime.Now,
                Status = cbStatus.SelectedItem.ToString(),
                Type = cbType.SelectedItem.ToString(),
                Priority = cbPriority.SelectedItem.ToString(),
                Location = (cbLocation.SelectedItem as LocationModel).Location,
                Description = txt_description.Text,
                DateDeadline = dateDeadline,
                CreatedUserId = parent.GetCurrentUser().UserId
            };

            // if added clear form
            if(CreateIncidentController.SaveIncident(parent, incident))
            {
                CleanForm();
            }
        }

        private void Btn_cancelCreationIncident_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The incident was NOT saved! You are being redirected to the overview.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Index parent = (Index)this.Parent;
            parent.HideViews("UCincidentManagementView");
        }
    }
}