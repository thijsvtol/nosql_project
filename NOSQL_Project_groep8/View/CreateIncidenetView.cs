using System;
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

        IncidentModel Incident;

        public CreateIncidenetView()
        {
            InitializeComponent();

            cbUsers.DataSource = CreateIncidentController.GetUsers();
            cbUsers.ValueMember = "UserId";
            cbUsers.DisplayMember = "FirstName";

            var dataSource = new List<string>();
            dataSource.Add("open");
            dataSource.Add("close");
            cbStatus.DataSource = dataSource;

            var type = new List<string>();
            type.Add("Software");
            type.Add("Hardware");
            type.Add("Service");
            cbType.DataSource = type;

            var priority = new List<string>();
            priority.Add("Low");
            priority.Add("Normal");
            priority.Add("High");
            cbPriority.DataSource = priority;

            var deadlineDays = new List<ComboboxItem>();
            deadlineDays.Add(new ComboboxItem() { Text = "7 days", Value = 7, Type = "day" });
            deadlineDays.Add(new ComboboxItem() { Text = "14 days", Value = 14, Type = "day" });
            deadlineDays.Add(new ComboboxItem() { Text = "26 days", Value = 26, Type = "day" });
            deadlineDays.Add(new ComboboxItem() { Text = "6 months", Value = 6, Type = "month" });
            cb_deadlineFollowUp.Items.Add(deadlineDays);
        }

        public CreateIncidenetView(IncidentModel incident)
        {
            InitializeComponent();

            MessageBox.Show(incident.DateCreated + incident.Subject + incident.Type + incident.Username + incident.Priority + incident.DateDeadline, incident.Location + incident.Status + incident.Description);
            this.Incident = incident;
            dateTimePicker1.Value = incident.DateCreated;
            txtSubject.Text = incident.Subject;
            cbType.Text = incident.Type;
            cbUsers.Text = incident.Username;
            cbPriority.Text = incident.Priority;
            cb_deadlineFollowUp.Text = incident.DateDeadline.ToString();
            txtLocation.Text = incident.Location;
            cbStatus.Text = incident.Status;
            txt_description.Text = incident.Description;
        }

        public void CleanForm()
        {
            cbUsers.SelectedIndex = -1;
            txtSubject.Text = "";
            cb_deadlineFollowUp.SelectedIndex = -1;
        }

        private void btnAddIncident_Click_1(object sender, EventArgs e)
        {
            if (txtSubject.Text == "" || string.IsNullOrEmpty(cb_deadlineFollowUp.Text) || txtLocation.Text == "" || txt_description.Text == "")
            {
                MessageBox.Show("Please fill in all the details!", "Fill Forum Details!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IncidentModel incidentModel = new IncidentModel()
                {
                    User = ((UserModel)cbUsers.SelectedItem).UserId,
                    Subject = txtSubject.Text,
                    DateCreated = DateTime.Now,
                    Status = "open",
                    Type = cbType.SelectedItem.ToString(),
                    Priority = cbPriority.SelectedItem.ToString(),
                    Location = txtLocation.Text,
                    Description = txt_description.Text
                };

                if ((cb_deadlineFollowUp.SelectedItem as ComboboxItem).Type == "day")
                {
                    DateTime dateDeadline = DateTime.Today.AddDays((cb_deadlineFollowUp.SelectedItem as ComboboxItem).Value);
                    incidentModel.DateDeadline = dateDeadline;
                }
                else if ((cb_deadlineFollowUp.SelectedItem as ComboboxItem).Type == "month")
                {
                    DateTime dateDeadline = DateTime.Today.AddMonths((cb_deadlineFollowUp.SelectedItem as ComboboxItem).Value);
                    incidentModel.DateDeadline = dateDeadline;
                }

                Index parent = (Index)this.Parent;
                incidentModel.Username = parent.GetCurrentUser().Username;
                incidentModel.UserEmail = parent.GetCurrentUser().Email;

                CreateIncidentController.SaveIncident(parent, incidentModel);
                CleanForm();
                MessageBox.Show("Incident was saved! You are being redirected to the overview.");
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

