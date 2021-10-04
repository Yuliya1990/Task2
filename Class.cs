using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Classes
{
    abstract class Student
    {
        public string Name, State;
        public Student(string name) { Name = name; State = ""; }
        public void Relax() { State = "Relax"; }
        public void Read() { State = "Read"; }
        public void Write() { State = "Write"; }
        public abstract void Study();
    }

    class GoodStudent : Student
    { 
        public GoodStudent(string name) : base(name)
        {
            State = "Good";
        }
        public override void Study()
        {
            Read(); Write(); Read(); Write(); Relax();
        }
    }

    class BadStudent: Student
    { 
        public BadStudent(string name):base(name)
        {
            State = "Bad";
        }
        public override void Study()
        {
            Relax(); Relax(); Relax(); Read();
        }
    }

    class Group
    {
        public string GroupName;
        public List<Student> students = new List<Student>();
        public Group(string group_name) { GroupName = group_name; }
        public void AddStudent(Student st) { students.Add(st); }
        public void GetInfo() 
        { 
            Console.WriteLine(GroupName);
            foreach (Student st in students)
            {
                Console.WriteLine(st.Name);
            }
        }
        public void GetFullInfo() 
        { 
            Console.WriteLine(GroupName); 
            foreach(Student st in students)
            {
                {
                    Console.WriteLine(st.Name + " " + st.State);
                }
            }
        }
    }
}
