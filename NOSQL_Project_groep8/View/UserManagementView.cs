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
using NOSQL_Project_groep8.Repositories;
using NOSQL_Project_groep8.Controller;

namespace NOSQL_Project_groep8.View
{
    public partial class UserManagementView : UserControl
    {

        UserManagementController UserOverview = new UserManagementController();
        private List<UserModel> GetAllUsers()
        {

            return UserOverview.GetAllUsers();

        }


        public void FillListView()
        {
            listViewUser.Items.Clear();
                List<UserModel> users = GetAllUsers();
                foreach (UserModel user in users)
                {
                    ListViewItem item = new ListViewItem(user.UserId.ToString());
                    item.SubItems.Add(user.Email);
                    item.SubItems.Add(user.FirstName);
                    item.SubItems.Add(user.LastName);
                    item.SubItems.Add(user.NumberOfTickets.ToString());
                    listViewUser.Items.Add(item);
                }
        }

        public UserManagementView()
        {
            InitializeComponent();

            FillListView();
        }

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

            if (parent.GetCurrentUser().TypeOfUser == "Employee")
            {
                btnAddNewUser.Hide();
                txtFilterEmail.Hide();
                foreach (ListViewItem item in listViewUser.Items)
                {
                    if (item.SubItems[0].Text.ToString() != parent.GetCurrentUser().UserId.ToString())
                    {
                        listViewUser.Items.Remove(item);
                    }
                }
            }
        }
    }
}
