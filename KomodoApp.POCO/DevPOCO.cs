using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoApp.POCO
{
    //Names, Unique ID Number, and PluralSight Access (t/f)
    //List what Developers need a PluralSight License
    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DevIdNumber { get; set; }
        public string HasPluralSightAccess { get; set; }

        public Developer() { }
        public Developer(string firstName, string lastName, string hasPluralSightAccess)
        {
            FirstName = firstName;
            LastName = lastName;
            HasPluralSightAccess = hasPluralSightAccess;
        }
    }
}
