using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.", AllowEmptyStrings = false), 
            StringLength(40, ErrorMessage = "The maximum allowed characters are 40 only.")]
        public string  Title { get; set; }

        [Required(ErrorMessage = "Incident Report Number is required.")]
        public string IRNumber { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime IncidentDate { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReportedDate { get; set; }

        [Required(ErrorMessage = "Please provied details of incident."), 
            StringLength(500, ErrorMessage = "You reached the maximum characters which is 500")]
        public string Details { get; set; }
        public string? IncidentLocation { get; set; }
        public IncidentStatus Status { get; set; }

    }
}
