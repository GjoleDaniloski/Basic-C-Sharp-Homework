using System;
using System.Collections.Generic;
using System.Text;

namespace Task03Students.Models
{
    public class Students
    {
        public Students()
        {
        }
        public Students(string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public string PrintInfo()
        {
            return $"Name of the student is {Name} and is on {Academy} academy and it's in the {Group} group";
        }
    }
}
