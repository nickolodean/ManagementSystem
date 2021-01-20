using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models.IMS
{
    public class RecommendedAction
    {
        enum Status
        {
            Closed,
            SubjectForDisciplinaryAction,
            ReInvestigate
        }

        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
