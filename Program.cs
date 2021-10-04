using System;

namespace Task2_Classes
{

    class Program
    {
     
        static void Main(string[] args)
        {
            GoodStudent Yulia = new GoodStudent("Yulia");
            BadStudent Sasha = new BadStudent("Sasha");
            Group K26 = new Group("K26");
            K26.AddStudent(Yulia);
            K26.AddStudent(Sasha);
            K26.GetInfo();
            K26.GetFullInfo();
        }

    }
}
