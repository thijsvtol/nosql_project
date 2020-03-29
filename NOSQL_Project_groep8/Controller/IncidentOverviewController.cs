using NOSQL_Project_groep8.Model;
using NOSQL_Project_groep8.Repositories;
using NOSQL_Project_groep8.Service;
using System.Collections.Generic;

namespace NOSQL_Project_groep8.Controller
{
    public class IncidentOverviewController
    {
        private static IncidentRepository IncidentRepository = new IncidentRepository();
        private static IncidentService IncidentService = new IncidentService();
        private static ArchiveService ArchiveService = new ArchiveService();

        public List<IncidentModel> GetIncidents()
        {
            List<IncidentModel> incidents = IncidentRepository.GetAllIncidents();
            return incidents;
        }

        public IncidentModel GetIncidentById(int incidentID)
        {
            IncidentModel archive = IncidentRepository.GetIncidentByID(incidentID);
            return archive;
        }

        public void DeleteIncident(IncidentModel incident)
        {
            ArchiveService.ArchiveIncident(incident);
            IncidentService.DeleteIncident(incident);
        }
    }
}