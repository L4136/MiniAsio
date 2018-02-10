using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniAsio
{
    class Student : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AsioId { get; set; }
        public string ClassId { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + AsioId + " " + ClassId;
        }
        public int CompareTo(object obj)
        {
            Student compareTo = (Student)obj;
            int lastnames = LastName.CompareTo(compareTo.LastName);
            if (lastnames == 0) return FirstName.CompareTo(compareTo.FirstName);
            return lastnames;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();
        
            Student student1 = new Student { FirstName = "Masa", LastName = "Niemi", AsioId = ""};
            Student student2 = new Student { FirstName = "Allan", LastName = "Aalto", AsioId = "A1111" };
            Student student3 = new Student { FirstName = "Hanna", LastName = "Husso", AsioId = "B2222" };
            Student student4 = new Student { FirstName = "Teppo", LastName = "Testaaja", AsioId = "C3333", ClassId = "TTV17S4" };

            students.Add(student1.AsioId, student1);
            students.Add(student2.AsioId, student2);
            students.Add(student3.AsioId, student3);
            students.Add(student4.AsioId, student4);

            foreach (Student student in students.Values)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
