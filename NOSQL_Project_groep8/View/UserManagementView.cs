using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Controller;

namespace NOSQL_Project_groep8.View
{
    public partial class UserManagementView : UserControl
    {

        UserManagementController UserOverview = new UserManagementController();
        IncidentOverviewController IncidentOverview = new IncidentOverviewController();
        AddUserView AddView = new AddUserView();
        UserModel CurrentUser;

        public UserManagementView()
        {
            InitializeComponent();
            FillListView();
        }

        public void FillListView()
        {
            listViewUser.Items.Clear();
            List<UserModel> users = UserOverview.GetAllUsers();
            List<IncidentModel> incidents = IncidentOverview.GetIncidents();

            foreach (UserModel user in users)
            {
                int NumberOfTickets = 0;
                foreach (var incident in incidents)
                {
                    if (user.UserId == incident.UserId)
                    {
                        NumberOfTickets++;
                    }
                }
                ListViewItem item = new ListViewItem(user.UserId.ToString());
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.FirstName);
                item.SubItems.Add(user.LastName);
                item.SubItems.Add(NumberOfTickets.ToString());
                item.SubItems.Add(user.TypeOfUser);

                listViewUser.Items.Add(item);
            }
        }

        public void CheckRole()
        {
            btnRemove.Hide();
            btnChangeRole.Hide();
            btnChangeRole.Hide();
            Index parent = (Index)this.Parent;


            if (CurrentUser.TypeOfUser == "Employee")
            {
                parent.HideViews("UCaddUserView");
            }
        }

        public void RefreshingLv()
        {
            FillListView();
            CheckRole();
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        ///                                      EVENTS                                        ///
        //////////////////////////////////////////////////////////////////////////////////////////
        
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            parent.HideViews("UCaddUserView");
        }

        private void txtFilterEmail_TextChanged(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            if (txtFilterEmail.Text == "")
            {
                FillListView();
            }
            else
            {
                foreach (ListViewItem item in listViewUser.Items)
                {
                    if (!item.SubItems[1].ToString().ToLower().Contains(txtFilterEmail.Text.ToLower()))
                    {
                        listViewUser.Items.Remove(item);
                    }
                }
            }

        }

        private void UserManagementView_Load(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            CurrentUser = parent.GetCurrentUser();
        }

        private void listViewUser_MouseClick(object sender, MouseEventArgs e)
        {
            btnChangeRole.Show();
            btnRemove.Show();
            if (listViewUser.SelectedItems[0].SubItems[5].Text == "Servicedesk")
            {
                btnChangeRole.Text = "CHANGE TO EMPLOYEE";
            }
            else
            {
                btnChangeRole.Text = "CHANGE TO SERVICEDESK";
            }
        }

        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel()
            {
                UserId = Convert.ToInt32(listViewUser.SelectedItems[0].SubItems[0].Text),
                TypeOfUser = listViewUser.SelectedItems[0].SubItems[5].Text,
            };
            UserOverview.ChangeRole(user);
            FillListView();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel()
            {
                UserId = Convert.ToInt32(listViewUser.SelectedItems[0].SubItems[0].Text),
            };
            UserOverview.DeleteUser(user);
            FillListView();
        }
    }
}
