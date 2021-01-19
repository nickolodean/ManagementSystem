using ManagementSystem.Models.HRIS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models.IMS
{
    public class Action
    {
        public int Id { get; set; }
        public string ImmediateAction { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateTakenAction { get; set; }
        public string CorrectiveAction { get; set; }
        public string RootCauseDetails { get; set; }


        // Foreign Keys
        [ForeignKey("EmployeeRefId")]
        public Employee Employee { get; set; }

    }
}
