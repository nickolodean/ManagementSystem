using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models.IMS
{
    public class InitialReport
    {
        public enum IncidentStatus
        {
            Created,
            ForVerification,
            ForAction,
            ActionBeingTaken,
            ForReview,
            ReInvestigate,
            SubjectToDA,
            Reviewed,
            Closed
            
        }

        public int Id { get; set; }
        public string  Title { get; set; }
        public string IRNumber { get; set; }
        public DateTime IncidentDate { get; set; }
        public DateTime ReportedDate { get; set; }
        public string Details { get; set; }
        public string IncidentLocation { get; set; }
        public IncidentStatus Status { get; set; }


    }
}
