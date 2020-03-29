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
    public partial class IncidentManagementView : UserControl
    {
        //controllers die worden gebruikert.
        IncidentOverviewController IncidentOverview = new IncidentOverviewController();
        UserManagementController UserController = new UserManagementController();
        //user die word ingevuld.
        UserModel currentUser;
        //class voor het sorteren van de listview.
        private ListViewColumnSorter lvwColumnSorter;
        //lijsten die worden ingevuld.
        List<IncidentModel> incidents = new List<IncidentModel>();
        List<UserModel> users = new List<UserModel>();

        //vul lijsten.
        private List<IncidentModel> GetAllIncidents()
        {
            return IncidentOverview.GetIncidents();
        }
        //vul lijsten.
        private List<UserModel> GetAllUsers()
        {
            return UserController.GetAllUsers();
        }
        //constructor
        public IncidentManagementView()
        {
            InitializeComponent();
            //verstop de LV voor alles word ingeladen.
            lv_incidents.Hide();
            //laad de LV in.
            listViewLoad();
            //kijk of er incidenten bestaan, zoja dan doe het volgende.
            if (lv_incidents.Items.Count > 0)
            {
                lv_incidents.Items[0].Focused = true;
                lv_incidents.Items[0].Selected = true;
                lv_incidents.FullRowSelect = true;
            }
            //show de LV.
            lv_incidents.Show();
        }
        //maak een nieuw incident aan.
        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            parent.HideViews("UCcreateIncidenetView");            
        }
        //vul de LV.
        public void listViewLoad()
        {            
            //activeer sorter.
            lvwColumnSorter = new ListViewColumnSorter();
            this.lv_incidents.ListViewItemSorter = lvwColumnSorter;
            //leeg alles.
            incidents.Clear();
            users.Clear();
            lv_incidents.Items.Clear();
            lv_incidents.Refresh();
            //vul de lijsten.
            incidents = GetAllIncidents();
            users = GetAllUsers();            
            //vul de LV aan met items per Incident
            foreach (IncidentModel incident in incidents)
            {
                ListViewItem item = new ListViewItem(incident.IncidentId.ToString());
                
                item.SubItems.Add(incident.Subject);
                foreach (UserModel user in users)
                {
                    if (incident.UserId == user.UserId)
                    {
                        item.SubItems.Add(user.Email);
                        item.SubItems.Add(user.FirstName + " " +user.LastName);
                        item.SubItems.Add(user.UserId.ToString());
                        break;
                    }                    
                }
                item.SubItems.Add(incident.DateCreated.ToString("MM/dd/yyyy H:mm"));
                item.SubItems.Add(incident.Status);
                lv_incidents.Items.Add(item);
                lv_incidents.Refresh();
            }     
            //maak de LV kopjes groot genoeg.
            foreach (ColumnHeader ch in this.lv_incidents.Columns)
            {
                ch.Width = -2;
            }            
        }
        //verander de lijst aan de hand van de input (gebaseerd op e-mail)
        private void txt_filterTickets_TextChanged(object sender, EventArgs e)
        {
            //bij een leeg filter laad je alles.
            if (txt_filterTickets.Text == "")
            {
                listViewLoad();
            }
            //zodra er iets is ingevuld gefilterd op input.
            else
            {
                foreach (ListViewItem item in lv_incidents.Items)
                {
                    if (!item.SubItems[2].ToString().ToLower().Contains(txt_filterTickets.Text.ToLower()))
                    {
                        lv_incidents.Items.Remove(item);
                    }
                }
            }
        }

        private void lv_incidents_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // kijk of het al geklikt is.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // verander van sorteer order.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // bij sorteren altijd ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }
            // sorteer.
            this.lv_incidents.Sort();
        }
        //vul this.user met de ingelogde user.
        private void IncidentManagementView_Load(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;            
            currentUser = parent.GetCurrentUser();
        }
        //kijk of de ingelogde user een Employee is of ServiceDesk medewerker.
        private void EmployeeOrService()
        {            
            if (currentUser.TypeOfUser == "Employee")
            {
                //hide wat de normale Employee niet hoeft te zien.
                btnCreateIncident.Hide();
                txt_filterTickets.Hide();
                btn_delete.Hide();
                //verwijder alle incidenten die niet van de gebruiker is.
                foreach (ListViewItem item in lv_incidents.Items)
                {
                    if (item.SubItems[4].Text.ToString() != currentUser.UserId.ToString())
                    {
                        lv_incidents.Items.Remove(item);
                        lv_incidents.Update();
                        lv_incidents.Refresh();
                    }
                }
            }
        }
        //refresh LV.
        public void refreshingLv()
        {
            listViewLoad();
            EmployeeOrService();
        }
        //verwijder incident.
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //vragen of gebruiker de incident echt wil verwijderen.
            if (MessageBox.Show("Are you sure you would like to delete this Incident?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //geef incident id mee om de gehele incident op te pakken.
                IncidentModel archive = IncidentOverview.GetIncidentById(int.Parse(lv_incidents.SelectedItems[0].SubItems[0].Text));
                //verwijder de gehele incident en sla hem op in een ander collection genaamd "Archive".
                IncidentOverview.DeleteIncident(archive);
                MessageBox.Show("You deleted the Incident!");
            }
            else
            {
                //bij het annuleren van een verwijdering komt een message op het scherm en word het geannuleerd.
                MessageBox.Show("The Incedent was not Deleted!");
            }
            //hoe dan ook word het LV vernieuwd.
            refreshingLv();
        }
    }
}