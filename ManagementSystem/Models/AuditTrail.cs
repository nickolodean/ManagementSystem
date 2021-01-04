using ManagementSystem.Models.HRIS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models
{
    public class AuditTrail
    {
        public int Id { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [Required, DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:h:mm:ss tt}", ApplyFormatInEditMode = true)]
        public DateTime Time { get; set; }
        public string Status { get; set; }
        public string? Remarks { get; set; }


        // Foreign Keys
        public virtual Employee Employee { get; set; }
    }
}
