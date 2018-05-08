using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu user will select from
            List<string> MenuList = new List<string>() {"1. List Tasks", "2. Add Task", "3. Delete Task", "4. Mark Task Complete", "5. Quit" };
            
            //created list(tasks) user can view and/or add things to do
            List<Input> inputList = new List<Input>();
            //input added to list
            inputList.Add(new Input("John", "check email", DateTime.Parse("01/01/2018")));

            //for the while loop
            bool repeat = true;
            
            while (repeat)
            {
                //foreach prints menu to the screen
                foreach (string elements in MenuList)
                {
                    Console.WriteLine(elements);
                }
                //prompts user to enter a number between 1 and the length of the menulist
                Console.WriteLine($"Enter a number 1-{MenuList.Count} ");
                string input = Console.ReadLine();

                //if user input is 1, it will display the input(tasks)
                if (input == "1")
                {
                    foreach (Input elements in inputList)
                    {
                        elements.PrintInfo();
                    }
                }
                //if user input is 2, it will prompt user to enter information to 
                else if (input == "2")
                {
                    Console.WriteLine("Enter a name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter a description");
                    string desc = Console.ReadLine();
                    Console.WriteLine("Enter a date: ");
                    string date = Console.ReadLine();

                    inputList.Add(new Input(name, desc, DateTime.Parse(date)));
                }
                else if (input == "3")
                {
                    foreach (Input elements in inputList)
                    {
                        elements.PrintInfo();
                    }
                    Console.WriteLine("What task(input) do you want to delete: ");
                    int index = int.Parse(Console.ReadLine());
                        inputList.RemoveAt(index-1);   
                }
                else if (input == "4")
                {
                    Console.WriteLine("What task(input) do you want to mark complete: ");
                    foreach (Input elements in inputList)
                    {
                        elements.PrintInfo();
                    }
                    int index = int.Parse(Console.ReadLine());

                    inputList[index - 1].Complete = true;

                }
                else if (input == "5")
                {
                    Console.WriteLine("Have a great day!");
                    break;
                }

                Console.WriteLine("Do you want to continue? y/n");
                if (Console.ReadLine().ToLower() == "n")
                {
                    repeat = false;
                }
                
            }

            

            



           
            
        }
    }
}
