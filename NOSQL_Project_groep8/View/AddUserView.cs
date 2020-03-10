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
            tbPassword.PasswordChar = '\u25CF';
            cbTypeEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
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
                    Password = tbPassword.Text
                };

                //Add user in DB
                if (Controller.AddUser(checkBoxAccept.Checked, user))
                {
                    ShowParentUserController();
                    ClearFields();
                }
            }
        }
    }
}
