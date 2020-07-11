using System;
using System.Collections.Generic;
using System.Text;

namespace Comp123_ProfTom_Inheritance1
{
    class DomesticStudent:Student
    {
        //PRIVATE INSTANCE MEMEBRS
        //PUBLIC PROPERTIES
        public string DomesticAddress { get; set; }
        //CONSTRUCTOR(S)
        public DomesticStudent(string name, int age, string student_id,string domestic_address)
            : base(name, age, student_id)
        {
            DomesticAddress = domestic_address;

        }
        //PRIVATE METHODS
        //PUBLIC METHODS
    }
}
