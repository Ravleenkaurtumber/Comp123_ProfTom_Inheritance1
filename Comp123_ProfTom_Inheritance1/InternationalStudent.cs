using System;
using System.Collections.Generic;
using System.Text;

namespace Comp123_ProfTom_Inheritance1
{
    class InternationalStudent:Student
    {
        //PRIVATE  INSTANCE MEMBERS
        //PUBLIC PROPERTIES
        public string InternationalAddress{ get; set; }
        //CONSTRUCTOR
        public InternationalStudent(string name,int age,string student_id,string international_address)
            :base(name,age,student_id)
        {
            InternationalAddress = international_address;
        }
            //PRIVATE METHODS
            //PUBLIC METHODS
    }
}
