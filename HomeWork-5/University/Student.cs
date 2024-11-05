using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Student
    {
        public enum Groupes
        {
            first,
            second,
            third
        }

        private string Name;
        private int Age;
        private Groupes Group;
        private string University;

        private string Univ = "University";


        public string Student_Name
        {
            get { return Name; }
            set
            {
                if (value.Length > 0 && value.Length <= 50)
                {
                    Name = value;
                }
                else
                {
                    throw new ArgumentException("The length of a student's name must be greater than zero and less than fifty");
                }
            }
        }

        public int Student_Age
        {
            get { return Age; }
            set
            {
                if (value >= 10 && value <= 65)
                {
                    Age = value;
                }
                else
                {
                    throw new ArgumentException("The student's age must be between ten and sixty-five");
                }
            }
        }

        public Groupes Student_Group
        {
            get { return Group; }
            set { Group = value; }
        }

        public string Student_University
        {
            get { return University; }
            set
            {
                if (value.Length > 0 && value.Length < 250 && value.Contains(Univ))
                {
                    University = value;
                }
                else
                {
                    throw new ArgumentException("The university name must be greater than zero and less than two hundred and fifty and must contain the word university.");
                }
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: {0}", Name ?? "No Name");
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Group: {0}", Group);
            Console.WriteLine("University: {0}", University ?? "No Data");
        }


    }
}
