using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models.MS
{
    public enum Role
    {
        ProjectManager,
        TeamLeader,
        Member
    }

    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
    }
}
