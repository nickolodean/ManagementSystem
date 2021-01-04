using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models.MS
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        // Collections
        public virtual ICollection<ContactPerson> Contacts { get; set; }
    }
}
