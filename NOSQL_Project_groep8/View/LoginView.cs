using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOSQL_Project_groep8.View
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            string password = txtPassword.Text;
            string testnaam = "test";
            string testpass = "test";

            
            if (username == testnaam && testpass == password)
            {
                Index parent = (Index)this.Parent;
                parent.HideViews("UCdashboardIncidentsView");
            }
            else
            {
                MessageBox.Show("Your password or username is wrong try again","Login failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}