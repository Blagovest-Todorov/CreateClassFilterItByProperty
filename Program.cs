using System;
using System.Collections.Generic;
using System.Linq;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(); // create a list Of Type Student

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end" )
                {                    
                    break;  //stops receiving lines of Names //exit teh loop
                }

                string[] data = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                // create array of strings , holding the each elem as a string, removign the Space
                string first = data[0];
                string last = data[1];
                int age = int.Parse(data[2]);
                string city = data[3];

                Student currStudent = new Student(); // we create an instance od Student Class

                currStudent.FirstName = first;  // fill each property of the current Object
                currStudent.LastName = last;
                currStudent.Age = age;
                currStudent.HomeTown = city;

                students.Add(currStudent); //adds the current Object into the List

            }

            string currCity = Console.ReadLine();

            List<Student> filteredStud = students
                           .Where(elem => elem.HomeTown == currCity)
                           .ToList();

            foreach (Student element in filteredStud)
            {
                Console.WriteLine($"{element.FirstName} {element.LastName} is {element.Age}" +
                $" years old.");
            }


            //foreach (Student item in students)
            //{
            //    if (item.HomeTown == currCity)
            //    {
            //       // Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age}" +
            //          //  $" years old.");
            //    }                
            //}
        }
    }

    class Student 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
