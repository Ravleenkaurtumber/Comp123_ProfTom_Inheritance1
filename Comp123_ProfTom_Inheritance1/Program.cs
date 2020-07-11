using System;

namespace Comp123_ProfTom_Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ravleen = new Person("Ravleen",20);
            Ravleen.SaysHello();
            //or string personstring=Ravleen.ToString();
            Console.WriteLine(Ravleen.ToString());
            Console.WriteLine();
            Person Bhavleen = new Person("Bhavleen", 10);
            Bhavleen.SaysHello();
            Console.WriteLine(Bhavleen.ToString());
            Console.WriteLine();
            Student Gurudaya = new Student("Gurudaya", 14, "g301101894");
            Gurudaya.SaysHello();
            Gurudaya.Studies();
            Console.WriteLine(Gurudaya.ToString());
            Console.WriteLine();
            InternationalStudent maxim = new InternationalStudent("maxim", 21, "f989887677788", "46 mantis road");
            maxim.SaysHello();
            maxim.Studies();
            Console.WriteLine(maxim.ToString());


        }
    }
}
