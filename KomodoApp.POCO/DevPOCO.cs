using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoApp.POCO
{
    public class DevPOCO
    {
        //Names, Unique ID Number, and PluralSight Access (t/f)
        //List what Developers need a PluralSight License

        public class Developer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int DevIdNumber { get; set; }
            public bool HasPluralSightAccess { get; set; }

            public Developer() { } //Empty Dev Constructor
            public Developer(string firstName, string lastName, bool hasPluralSightAccess)
            {
                FirstName = firstName;
                LastName = lastName;
                HasPluralSightAccess = hasPluralSightAccess;
            }

        }
    }
}
