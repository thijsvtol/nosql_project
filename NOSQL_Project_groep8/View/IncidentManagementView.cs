using System;
using System.Collections.Generic;
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
        UserModel CurrentUser;
        //class voor het sorteren van de listview.
        private ListViewColumnSorter LvwColumnSorter;
        //lijsten die worden ingevuld.
        List<IncidentModel> Incidents = new List<IncidentModel>();
        List<UserModel> Users = new List<UserModel>();

        //constructor
        public IncidentManagementView()
        {
            InitializeComponent();
            //verstop de LV voor alles word ingeladen.
            lv_incidents.Hide();
            //laad de LV in.
            ListViewLoad();
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

        //vul de LV.
        public void ListViewLoad()
        {
            //activeer sorter.
            LvwColumnSorter = new ListViewColumnSorter();
            this.lv_incidents.ListViewItemSorter = LvwColumnSorter;
            //leeg alles.
            Incidents.Clear();
            Users.Clear();
            lv_incidents.Items.Clear();
            lv_incidents.Refresh();
            //vul de lijsten.
            Incidents = IncidentOverview.GetIncidents();
            Users = UserController.GetAllUsers();
            //vul de LV aan met items per Incident
            foreach (IncidentModel incident in Incidents)
            {
                ListViewItem item = new ListViewItem(incident.IncidentId.ToString());

                item.SubItems.Add(incident.Subject);
                foreach (UserModel user in Users)
                {
                    if (incident.UserId == user.UserId)
                    {
                        item.SubItems.Add(user.Email);
                        item.SubItems.Add(user.FirstName + " " + user.LastName);
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

        //kijk of de ingelogde user een Employee is of ServiceDesk medewerker.
        private void EmployeeOrService()
        {
            if (CurrentUser.TypeOfUser == "Employee")
            {
                //hide wat de normale Employee niet hoeft te zien.
                btnCreateIncident.Hide();
                txt_filterTickets.Hide();
                btn_delete.Hide();
                //verander label
                lbIncidentManagement.Text = "Your Tickets";
                //verwijder alle incidenten die niet van de gebruiker is.
                foreach (ListViewItem item in lv_incidents.Items)
                {
                    if (item.SubItems[4].Text.ToString() != CurrentUser.UserId.ToString())
                    {
                        lv_incidents.Items.Remove(item);
                        lv_incidents.Update();
                        lv_incidents.Refresh();
                    }
                }
            }
        }

        //refresh LV.
        public void RefreshingLv()
        {
            ListViewLoad();
            EmployeeOrService();
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        ///                                      EVENTS                                        ///
        //////////////////////////////////////////////////////////////////////////////////////////

        //vul this.user met de ingelogde user.
        private void IncidentManagementView_Load(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            CurrentUser = parent.GetCurrentUser();
        }

        //maak een nieuw incident aan.
        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            parent.HideViews("UCcreateIncidenetView");
        }

        //verander de lijst aan de hand van de input (gebaseerd op e-mail)
        private void txt_filterTickets_TextChanged(object sender, EventArgs e)
        {
            //bij een leeg filter laad je alles.
            if (txt_filterTickets.Text == "")
            {
                ListViewLoad();
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

        //sorteer colom.
        private void lv_incidents_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //kijk of het al geklikt is.
            if (e.Column == LvwColumnSorter.SortColumn)
            {
                //verander van sorteer order.
                if (LvwColumnSorter.Order == SortOrder.Ascending)
                {
                    LvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    LvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                //bij sorteren altijd ascending.
                LvwColumnSorter.SortColumn = e.Column;
                LvwColumnSorter.Order = SortOrder.Ascending;
            }
            //sorteer.
            this.lv_incidents.Sort();
        }

        //verwijder incident.
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lv_incidents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select an Incident.");
            }
            else
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
                    MessageBox.Show("The Incident was not Deleted!");
                }
            }
            //hoe dan ook word het LV vernieuwd.
            RefreshingLv();
        }
    }
}