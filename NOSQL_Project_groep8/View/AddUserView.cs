using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NOSQL_Project_groep8.Controller;
using NOSQL_Project_groep8.Model;

namespace NOSQL_Project_groep8.View
{
    public partial class AddUserView : UserControl
    {
        private AddUserController Controller = new AddUserController();
        

        public AddUserView()
        {
            InitializeComponent();
            btnUpdateUser.Hide();
            tbPassword.PasswordChar = '\u25CF';
            tbFavColor.PasswordChar = '\u25CF';
            cbTypeEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            FillLocationCB();
        }
        
        private void ShowParentUserController()
        {
            //Go back to UMV
            Index parent = (Index)this.Parent;
            parent.HideViews("UCuserManagementView");
        }

        private void ClearFields()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }
            foreach (ComboBox cb in this.Controls.OfType<ComboBox>())
            {
                cb.Text = null;
            }
        }

        //Fill the location's combobox with all locations from the DB
        private void FillLocationCB()
        {
            List<LocationModel> locations = Controller.GetLocations();
            foreach (var item in locations)
            {
                cbLocation.Items.Add(item.Location);
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////
        ///                                      EVENTS                                        ///
        //////////////////////////////////////////////////////////////////////////////////////////


        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowParentUserController();
            ClearFields();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (Controller.CheckComboboxes(cbTypeEmployee, cbLocation))
            {
                //Fill model
                UserModel user = new UserModel()
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text,
                    TypeOfUser = cbTypeEmployee.SelectedItem.ToString(),
                    Email = tbEmail.Text,
                    Phonenumber = tbPhonenumber.Text,
                    Location = cbLocation.SelectedItem.ToString(),
                    Username = tbUsername.Text,
                    Password = tbPassword.Text,
                    FavColor = tbFavColor.Text
                };

                //Add user in DB
                if (Controller.AddUser(checkBoxAccept.Checked, user))
                {
                    ShowParentUserController();
                    ClearFields();
                }
            }
        }

        private void AddUserView_Load(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;

            if (parent.GetCurrentUser().TypeOfUser == "Employee")
            {
                changeAddToProfile();
            }
        }

        private void changeAddToProfile()
        {
            Index parent = (Index)this.Parent;
            lblAddUserHeader.Text = "Your profile";
            lblUsername.Hide();
            lblPassword.Hide();
            label1.Hide();
            lblSendPassword.Hide();
            lblEmployee.Hide();

            tbUsername.Hide();
            tbPassword.Hide();
            txtFavColor.Hide();

            checkBoxAccept.Hide();
            cbTypeEmployee.Hide();


            btnAddUser.Hide();
            btnCancel.Hide();

            btnUpdateUser.Show();

            tbFirstName.Text = parent.GetCurrentUser().FirstName;
            tbLastName.Text = parent.GetCurrentUser().LastName;
            tbEmail.Text = parent.GetCurrentUser().Email;
            tbPhonenumber.Text = parent.GetCurrentUser().Phonenumber;
            cbLocation.Text = parent.GetCurrentUser().Location;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {

        }
    }
}
