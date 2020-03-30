using System;
using System.Collections.Generic;
using System.Linq;
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
            UserManagementView userView = new UserManagementView();
            userView.FillListView();
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

        //Change Add user to Edit User
        public void ChangeAddToProfile()
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
            tbFavColor.Hide();

            checkBoxAccept.Hide();
            cbTypeEmployee.Hide();


            btnAddUser.Hide();
            btnCancel.Hide();

            btnUpdateUser.Show();
            FillTextBoxesWithUser();
        }

        //Edit user fill panel
        private void FillTextBoxesWithUser()
        {
            Index parent = (Index)this.Parent;
            tbFirstName.Text = parent.GetCurrentUser().FirstName;
            tbLastName.Text = parent.GetCurrentUser().LastName;
            tbEmail.Text = parent.GetCurrentUser().Email;
            tbPhonenumber.Text = parent.GetCurrentUser().Phonenumber;
            cbLocation.Text = parent.GetCurrentUser().Location;
        }

        //Edit user validation
        private void CheckIfChanged(TextBox changedTextbox)
        {
            Index parent = (Index)this.Parent;
            if (changedTextbox.Name == "tbFirstName")
            {
                if (parent.GetCurrentUser().FirstName != tbFirstName.Text)
                {
                    btnUpdateUser.Enabled = true;
                }
                else
                {
                    btnUpdateUser.Enabled = false;
                }
            }
            else if (changedTextbox.Name == "tbLastName")
            {
                if (parent.GetCurrentUser().LastName != tbLastName.Text)
                {
                    btnUpdateUser.Enabled = true;
                }
                else
                {
                    btnUpdateUser.Enabled = false;
                }
            }
            else if (changedTextbox.Name == "tbEmail")
            {
                if (parent.GetCurrentUser().Email != tbEmail.Text)
                {
                    btnUpdateUser.Enabled = true;
                }
                else
                {
                    btnUpdateUser.Enabled = false;
                }
            }
            else if (changedTextbox.Name == "tbPhonenumber")
            {
                if (parent.GetCurrentUser().Phonenumber != tbPhonenumber.Text)
                {
                    btnUpdateUser.Enabled = true;
                }
                else
                {
                    btnUpdateUser.Enabled = false;
                }
            }
        }

        private void CheckIfChanged(ComboBox changedTextbox)
        {
            Index parent = (Index)this.Parent;
            if (changedTextbox.Name == "cbLocation")
            {
                if (parent.GetCurrentUser().Location != cbLocation.SelectedText)
                {
                    btnUpdateUser.Enabled = true;
                }
                else
                {
                    btnUpdateUser.Enabled = false;
                }
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        ///                                      EVENTS                                        ///
        //////////////////////////////////////////////////////////////////////////////////////////

        private void AddUserView_Load(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;

            if (parent.GetCurrentUser().TypeOfUser == "Employee")
            {
                ChangeAddToProfile();
                btnBack.Hide();
            }
        }

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

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (Controller.ValidateEmail(tbEmail.Text)){
                MessageBox.Show("Emailaddress has an invalid input.");
            }
            else
            {
                Index parent = (Index)this.Parent;
                UserModel user = Controller.GetUserById(parent.GetCurrentUser().UserId);
                user.FirstName = tbFirstName.Text;
                user.LastName = tbLastName.Text;
                user.Email = tbEmail.Text;
                user.Phonenumber = tbPhonenumber.Text;
                user.Location = cbLocation.Text;
                try
                {
                    Controller.UpdateUser(user);
                    MessageBox.Show("Succesfully updated your profile!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Oops! Something went wrong!");
                }
                btnUpdateUser.Enabled = false;
            }

        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            CheckIfChanged(tbFirstName);
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            CheckIfChanged(tbLastName);
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            CheckIfChanged(tbEmail);
        }

        private void tbPhonenumber_TextChanged(object sender, EventArgs e)
        {
            CheckIfChanged(tbPhonenumber);

        }

        private void cbLocation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckIfChanged(cbLocation);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            parent.HideViews("UCuserManagementView");
        }
    }
}
