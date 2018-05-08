using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2
{
    class Input
    {
        private string _name;
        private string _description;
        private DateTime _due;
        private bool _complete;

        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        public string Description
        {
            set
            {
                _description = value;
            }
            get
            {
                return _description;
            }
        }

        public DateTime Due
        {
            set
            {
                _due = value;
            }
            get
            {
                return _due;
            }
        }

        public bool Complete
        {
            set
            {
                _complete = value;
            }
            get
            {
                return _complete;
            }
        }

        public Input(string n, string d, DateTime dt)
        {
            Name = n;
            Description = d;
            Due = dt;
            Complete = false;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Member Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Due Date: {Due}");
        }













    }



    
}
