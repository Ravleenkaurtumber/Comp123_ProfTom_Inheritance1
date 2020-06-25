using System;
using System.Collections.Generic;
using System.Text;

namespace Comp123_ProfTom_Inheritance1
{
    class Person
    {
        //PRIVATE INSTANCE VARIABLES(FIELDS)
        private string m_name;
        private int m_age;
        //PUBLIC PROPERTIES
        public string Name
        {
            get//accessor
            {
                return m_name;

            }
            set//mutattor
            {
                m_name = value;
            } 
        }
        public int Age {
            get
            {

                return m_age;
            }

            set
            {
                m_age = value;

            }
        }
        //CONSTRUCTOR
         public Person(string name,int age)
        {
            m_name = name;
            m_age = age;
        }
        //PRIVATE METHODS
        //PUBLIC METHODS
         public  void SaysHello()//no return tyep so void
        {
            Console.WriteLine( $"{Name} says Hello");//if use property m_name it is powerfull
        }
        /// <summary>
        /// this method overrides the superclass ToString Method
        /// </summary>
        /// <returns>
        /// this method returns a formatted string that displays class properties 
        /// </returns>
        public override string ToString()

        {
            string outputString = "";
            outputString += "\n++++++++++++++++++\n";
            outputString += $"Name:{Name}   \n";
            outputString += $"Age:{Age}     \n";
            outputString += "++++++++++++++++++\n";
            return outputString;
        }

    }
}
