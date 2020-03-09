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
        CreateIncidentController createIncidenetController = new CreateIncidentController();
        
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


        }

        private List<UserModel> GetUsers()
        {

            return createIncidenetController.GetUsers();

        }

        public void CleanForm()
        {
            cbUsers.SelectedIndex = -1;
            txtSubject.Text = "";
            cb_deadlineFollowUp.SelectedIndex = -1;
        }

        private void btnAddIncident_Click_1(object sender, EventArgs e)
        {
            if (txtSubject.Text == "" || string.IsNullOrEmpty(cb_deadlineFollowUp.Text) || txtLocation.Text == "" || txt_description.Text =="")
            {
                MessageBox.Show("Please fill in all the details!", "Fill Forum Details!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                IncidentModel incidentModel = new IncidentModel();
                incidentModel.User = ((UserModel)cbUsers.SelectedItem).UserId;
                incidentModel.Subject = txtSubject.Text;
                incidentModel.DateCreated = DateTime.Now;
                incidentModel.Status = "open";
                incidentModel.Type = cbType.SelectedItem.ToString();
                incidentModel.Priority = cbPriority.SelectedItem.ToString();
                incidentModel.Location = txtLocation.Text;
                incidentModel.Description = txt_description.Text;

                if (cb_deadlineFollowUp.Text == "7 days")
                {
                    DateTime dateDeadline = DateTime.Today.AddDays(7);
                    incidentModel.DateDeadline = dateDeadline;
                }
                else if (cb_deadlineFollowUp.Text == "14 days")
                {
                    DateTime dateDeadline = DateTime.Today.AddDays(14);
                    incidentModel.DateDeadline = dateDeadline;
                }
                else if (cb_deadlineFollowUp.Text == "28 days")
                {
                    DateTime dateDeadline = DateTime.Today.AddDays(28);
                    incidentModel.DateDeadline = dateDeadline;
                }
                else if (cb_deadlineFollowUp.Text == "6 months")
                {
                    DateTime dateDeadline = DateTime.Today.AddMonths(6);
                    incidentModel.DateDeadline = dateDeadline;
                }

                MessageBox.Show("Incident was saved! You are being redirected to the overview.");

                Index parent = (Index)this.Parent;

                createIncidenetController.SaveIncident(parent, incidentModel);
                CleanForm();
            }
        }

        private void Btn_cancelCreationIncident_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The incident was NOT saved! You are being redirected to the overview.", "Warning!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            Index parent = (Index)this.Parent;
            parent.HideViews("UCincidentManagementView");
        }
    }
}
