using System;
using System.Collections.Generic;
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

        public int Id { get; set; }
        public string Description { get; set; }
    }
}
