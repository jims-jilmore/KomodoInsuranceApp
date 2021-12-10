using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KomodoApp.POCO;
using KomodoApp.REPO;

namespace KomodoApp.UI
{
    class ProgramUI
    {
        private readonly DevRepo _devRepo = new DevRepo();
        private readonly DevTeamRepo _devTeamRepo = new DevTeamRepo();

        //public bool isAppRunning = true;
        public void Run()
        {
            RunApplication();
        }
        private void RunApplication()
        {
          //  StartMenu();
            bool isAppRunning = true;
            while (isAppRunning)
            {
                MainMenu();
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        DevMenu();
                        break;
                    case "2":
                        DevTeamMenu();
                        break;
                    case "99": //<<<--------Something not working here. Cant close program<<<--------
                        isAppRunning = false; 
                        break;
                    default:
                        //Console.WriteLine("Please choose one of options");
                        //Thread.Sleep(5000);
                        break;
                }
            }
        }
        public void StartMenu()
        {
            //Welcome Screen
            Console.Clear();
            Console.WriteLine("**************************** \n" +
                "Welcome to the Komodo Insurance Team Management App \n" +
                "Press enter to continue \n" +
                "****************************");
            Console.ReadLine();
        } 
        public void MainMenu()
        {
            //Main Menu that gives you choices between Managing a Dev or a Dev Team
            Console.Clear();
            Console.WriteLine(
                "Please Select An Option \n" + 
                "**************************** \n" +
                "1: Manage Developer \n" +
                "2: Manage Developer Team \n" +
                "99: Exit Application \n" +
                "****************************");
             string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    DevMenu();
                    break;
                case "2":
                    DevTeamMenu();
                    break;
                case "99"://<<<----Might be broke here too. This or in RunApp<<<--------
                    Console.Clear(); 
                    break;
                default:
                    Console.WriteLine("Please choose one of the options");
                    break;
            }
        }
        public void DevMenu()
        {
            //Dev management menu
            Console.Clear();
            Console.WriteLine(
                "Please select an option: \n" +
                "************************** \n" +
                "1: View Developer \n" +
                "2: View All Developers \n" +
                "3: Add Developer \n" +
                "4: Remove Developer \n" +
                "5: Update Developer Information \n" +
                "6: Return to Main Menu \n" +
                "99: Exit Application \n" +
                "**************************");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    ViewDev(); //<<-see below
                    break;
                case "2":
                    ViewAllDevs();
                    break;
                case "3":
                    AddDeveloper();
                    break;
                case "4":
                    //placeholder(removeDev)
                    break;
                case "5":
                    //placeholder(updateDev)
                    break;
                case "6":
                    MainMenu();
                    break;
                case "99":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please choose one of the options");
                    break;
            }
        }

        private void DevInfo(Developer developer)
        {
            Console.WriteLine($"{developer.FirstName} {developer.LastName} \n" +
                $"Developer ID Number: {developer.DevIdNumber} \n" +
                $"Access to Pluralsight: {developer.HasPluralSightAccess} \n" +
                $"******************************* \n"); 
        }

        private void ViewAllDevs()
        {
            Console.Clear();

            List<Developer> allDevs = _devRepo.GetDevelopers();
            foreach (var developer in allDevs)
            {
                DevInfo(developer);
            }
        }

        private void ViewDev()
        {
            Console.Clear();
            List<Developer> listSingleDev = _devRepo.GetDevelopers();
            Console.WriteLine(listSingleDev[0]); //<<<-something busted here. Console Returns weird message
        }

        private void AddDeveloper()
        {
            Console.Clear();

            Console.WriteLine("Enter the Developers First Name");
            string devFirstName = Console.ReadLine();
            Console.WriteLine("Enter the Devlopers Last Name");
            string devLastName = Console.ReadLine();
            Console.WriteLine("Does the Developer have PluralSight Acces (Y/N)");
            string devPluralAccess = Console.ReadLine();
            string convertedPluralAccess = devPluralAccess.ToUpper();
            /*switch (convertedPluralAccess)
            {
                case "Y":
                    Console.WriteLine("TestTestTest");
                    break;
                case "N":
                    Console.WriteLine("Test2Test2");
                    break;
                default:
                    Console.WriteLine("Please enter Y or N");
                    break;
            }
            */
            Developer devToBeAdded = new Developer(devFirstName, devLastName, convertedPluralAccess);

            bool devAddSuccess = _devRepo.AddDeveloper(devToBeAdded);
            if (devAddSuccess)
            {
                Console.WriteLine(
                    $"{devFirstName} successfully added to the database \n" +
                    "Press Enter to Continue");
            }
            else
            {
                Console.WriteLine(
                    "ERROR \n" +
                    "Developer not added to the database");
            }
        }

        public void DevTeamMenu()
        {
            //DevTeam management menu
            Console.Clear();
            Console.WriteLine(
                "Please select an option: \n" +
                "************************** \n" +
                "1: View Developer Teams \n" +
                "2: Add Developer Team \n" +
                "3: Remove Developer Team \n" +
                "4: Update Developer Team \n" +
                "5: Return to Main Menu \n" +
                "99: Exit Application \n" +
                "**************************");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //placeholder(view DevTeam)
                    break;
                case "2":
                    //placeholder(add DevTeam)
                    break;
                case "3":
                    //placeholder(Remove DevTeam)
                    break;
                case "4":
                    //placeholder(Update DevTeam)
                    break;
                case "5":
                    MainMenu();
                    break;
                case "99":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please choose one of the options");
                    break;
            }
        }
    }
}
