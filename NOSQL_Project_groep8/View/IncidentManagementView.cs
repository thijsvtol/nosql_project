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
        IncidentOverviewController IncidentOverview = new IncidentOverviewController();
        UserManagementController UserController = new UserManagementController();
        UserModel currentUser;
        //class voor het sorteren van de listview
        private ListViewColumnSorter lvwColumnSorter;
        List<IncidentModel> incidents = new List<IncidentModel>();
        List<UserModel> users = new List<UserModel>();
        private List<IncidentModel> GetAllIncidents()
        {
            return IncidentOverview.GetIncidents();
        }

        private List<UserModel> GetAllUsers()
        {
            return UserController.GetAllUsers();
        }

        public IncidentManagementView()
        {
            InitializeComponent();
            lv_incidents.Hide();
            listViewLoad();
            if (lv_incidents.Items.Count > 0)
            {
                lv_incidents.Items[0].Focused = true;
                lv_incidents.Items[0].Selected = true;
                lv_incidents.FullRowSelect = true;
            }            
        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            parent.HideViews("UCcreateIncidenetView");            
        }

        public void listViewLoad()
        {            
            lvwColumnSorter = new ListViewColumnSorter();
            this.lv_incidents.ListViewItemSorter = lvwColumnSorter;

            incidents.Clear();
            users.Clear();

            lv_incidents.Items.Clear();
            lv_incidents.Refresh();

            incidents = GetAllIncidents();
            users = GetAllUsers();            

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
            foreach (ColumnHeader ch in this.lv_incidents.Columns)
            {
                ch.Width = -2;
            }            
        }

        private void txt_filterTickets_TextChanged(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;
            if (txt_filterTickets.Text == "")
            {
                listViewLoad();
            }
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

        private void lv_incidents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (var incident in incidents)
            {
                if (lv_incidents.SelectedItems[0].SubItems[0].Text == incident.IncidentId.ToString())
                {
                    CreateIncidenetView changeIncident = new CreateIncidenetView();
                    changeIncident.changeIncident(incident);

                    Index parent = (Index)this.Parent;
                    parent.HideViews("UCcreateIncidenetView");

                    break;
                }
            }
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

        private void IncidentManagementView_Load(object sender, EventArgs e)
        {
            Index parent = (Index)this.Parent;            
            currentUser = parent.GetCurrentUser();
        }

        private void EmployeeOrService()
        {            
            if (currentUser.TypeOfUser == "Employee")
            {
                btnCreateIncident.Hide();
                txt_filterTickets.Hide();
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
        public void refreshingLv()
        {
            listViewLoad();
            EmployeeOrService();
            lv_incidents.Show();
        }
    }
}