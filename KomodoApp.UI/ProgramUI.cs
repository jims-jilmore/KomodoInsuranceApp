using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoApp.POCO;
using KomodoApp.REPO;

namespace KomodoApp.UI
{
    class ProgramUI
    {
        private readonly DevRepo _devRepo = new DevRepo();
        private readonly DevTeamRepo _devTeamRepo = new DevTeamRepo();

        public bool isApprunning = true;
        public void Run()
        {
            RunApplication();
        }
        private void RunApplication()
        {
            StartMenu();

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
                    case "99":
                        isAppRunning = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please choose one of options");
                        break;
                }
            }

        }
        public void StartMenu()
        {
            //Some Kind of Welcome Screen
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
                case "99":
                    Console.Clear();
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
                "1: View Current Developers \n" +
                "2: Add Developer \n" +
                "3: Remove Developer \n" +
                "4: Update Developer Information \n" +
                "5: Return to Main Menu \n" +
                "99: Exit Application \n" +
                "**************************");
            //switch case for next part goes here
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //placeholder
                    break;
                case "2":
                    //placeholder
                    break;
                case "3":
                    //placeholder
                    break;
                case "4":
                    //placeholder
                    break;
                case "5":
                    MainMenu();
                    break;
                case "99":
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please choose one of the options");
                    break;
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
            //switch case for next part goes here
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //placeholder
                    break;
                case "2":
                    //placeholder
                    break;
                case "3":
                    //placeholder
                    break;
                case "4":
                    //placeholder
                    break;
                case "5":
                    MainMenu();
                    break;
                case "99":
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please choose one of the options");
                    break;
            }
        }
    }
}
