using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoApp.POCO
{
    class DevTeamPOCO
    {
        //Team Members(First/Last Name), Team Name, Team Unique ID
        public class DevTeam
        {
            public string TeamName { get; set; }
            public int TeamID { get; set; }
            public string TeamMember { get; set; } //This will need to hold Dev First/Last Name.
            public DevTeam() { }
            public DevTeam(string teamName, string teamMember)
            {
                TeamName = teamName;
                TeamMember = teamMember;
            }
        }
    }
}
