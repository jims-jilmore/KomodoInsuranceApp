using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoApp.POCO;

namespace KomodoApp.REPO
{
    public class DevRepo
    {
        private readonly List<Developer> _developers = new List<Developer>(); //Database of Developers

        private int _idNumber = 0; //Could also make a random number generator and store the value
        public List<Developer> GetDevelopers()
        {
            return _developers;
        }
        public Developer GetDev(int ID)
        {
            int convertedID = Convert.ToInt32(ID);
            foreach (Developer developer in _developers)
            {
                if (convertedID == developer.DevIdNumber)
                {
                    return developer;
                }
            }
            Console.WriteLine("Invalid Developer ID");
            return null;
        }

        public bool AddDeveloper(Developer developer)
        {
           if (developer is null)
            {
                return false;
            }
            _idNumber++;
            developer.DevIdNumber = _idNumber;
            _developers.Add(developer);
            return true;
        }



        

        //CRUD Methods
        //Add or Remove Developer
        //Add or Remove Multiple Developers at a time
        //View Developer Specifics
    }
}
