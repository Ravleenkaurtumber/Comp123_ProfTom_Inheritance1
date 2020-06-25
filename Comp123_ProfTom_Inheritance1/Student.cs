using System;
using System.Collections.Generic;
using System.Text;

namespace Comp123_ProfTom_Inheritance1
{
    class Student:Person
    {
        //PRIVATE INSTANCE VARIABLES
        private string m_studentID;
        //PUBLIC PROPERTIES
        public string StudentID
        {
            get
            {
                return m_studentID;
            }

            set
            {
                m_studentID = value;
            }
        }
        //CONSTRUCOR
        public Student(string name, int age, string student_id)
            : base(name, age)
        {
            StudentID = student_id;
        }

        //PRIVATE METHOD 
        //PUBLIC METHOD
        public void Studies()
        {
            Console.WriteLine($"{Name} is Studying");
        }
        public override string ToString()
        {
            string outputString = "";
            outputString += "\n++++++++++++++++++\n";
            outputString += $"Name:{Name}   \n";
            outputString += $"Age:{Age}     \n";
            outputString += $"StudentID:{StudentID}\n";
            outputString += "++++++++++++++++++\n";
            
            return outputString;
        }
    }
}
