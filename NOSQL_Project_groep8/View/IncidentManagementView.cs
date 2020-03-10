﻿using System;
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
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        IncidentOverviewController IncidentOverview = new IncidentOverviewController();

       
=======
=======
>>>>>>> Stashed changes
        IncidentOverviewController IncidentOverview = new IncidentOverviewController();

        //class voor het sorteren van de listview
        private ListViewColumnSorter lvwColumnSorter;

        List<IncidentModel> incidents = new List<IncidentModel>();

<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        private List<IncidentModel> GetAllIncidents()
        {

            return IncidentOverview.GetIncidents();

        }


<<<<<<< Updated upstream
<<<<<<< Updated upstream



=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        public IncidentManagementView()
        {
            InitializeComponent();

<<<<<<< Updated upstream
<<<<<<< Updated upstream
            List<IncidentModel> incidents = GetAllIncidents();
            foreach (IncidentModel incident in incidents)
            {
                ListViewItem item = new ListViewItem(incident.IncidentId.ToString());
                item.SubItems.Add(incident.Subject);
                item.SubItems.Add(incident.User.ToString());
                item.SubItems.Add(incident.DateCreated.ToString());
                item.SubItems.Add(incident.Status);
                lv_incidents.Items.Add(item);
            }

            









        }
            
        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            parent.HideViews("UCcreateIncidenetView");
        }

        
=======
=======
>>>>>>> Stashed changes
            lvwColumnSorter = new ListViewColumnSorter();
            this.lv_incidents.ListViewItemSorter = lvwColumnSorter;


            listViewLoad();

            lv_incidents.Items[0].Focused = true;
            lv_incidents.Items[0].Selected = true;
            lv_incidents.FullRowSelect = true;


        }
            
        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            parent.HideViews("UCcreateIncidenetView");
        }

        public void listViewLoad()
        {



            incidents.Clear();

            lv_incidents.Items.Clear();

            incidents = GetAllIncidents();

            foreach (IncidentModel incident in incidents)
            {
                ListViewItem item = new ListViewItem(incident.IncidentId.ToString());
                item.SubItems.Add(incident.UserEmail);
                item.SubItems.Add(incident.Subject);
                item.SubItems.Add(incident.Username);
                item.SubItems.Add(incident.DateCreated.ToString("MM/dd/yyyy H:mm"));
                item.SubItems.Add(incident.Status);
                lv_incidents.Items.Add(item);

            }

        }

        private void txt_filterTickets_TextChanged(object sender, EventArgs e)
        {
            if (txt_filterTickets.Text == "")
            {
                listViewLoad();
            }
            else
            {
                foreach (ListViewItem item in lv_incidents.Items)
                {
                    if (!item.SubItems[1].ToString().ToLower().Contains(txt_filterTickets.Text.ToLower()))
                    {
                        lv_incidents.Items.Remove(item);
                    }
                }
            }
        }

        private void lv_incidents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            /*foreach (var incident in incidents)
            {
                if (lv_incidents.SelectedItems[0].SubItems[0].Text == incident.IncidentId.ToString())
                {


                    CreateIncidenetView changeIncident = new CreateIncidenetView(incident);
                    Index parent = (Index)this.Parent;
                    parent.HideViews("UCchangeIncidenetView");
                    break;
                }

            }*/

        }

        private void lv_incidents_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // kijk of het al geklikt is...
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // verander van sorteer order...
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
                // bij sorteren altijd ascending...
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // sorteer...
            this.lv_incidents.Sort();
        }
>>>>>>> Stashed changes
    }
}
