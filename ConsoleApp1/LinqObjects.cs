using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBasics.Models;

namespace LinqBasics
{
    public class LinqObjects
    {
		List<Student>  students = new List<Student>();
		

		public void Initialize() 
		{
            students.Add(new Student(101, "James", "Smith"));
            students.Add(new Student(102, "Robert", "Smith"));
            students.Add(new Student(103, "Maria", "Rodriguez"));
            students.Add(new Student(104, "David", "Smith"));
            students.Add(new Student(105, "James", "Johnson"));
            students.Add(new Student(106, "John", "SevenLast"));
            students.Add(new Student(107, "Maria", "Garcia"));
            students.Add(new Student(108, "Mary", "Smith"));
        }
        public void filterStudentQuery()
        {
            Console.WriteLine("Query syntax");
            
            IEnumerable<Student> query = from s in students
                                         where s.LastName == "Smith"
                                         select s;
            foreach (var item in query)
            {
                Console.WriteLine(item.FirstName);
            }
        }

        public void filterStudentMethod()
        {
            
            Console.WriteLine("Method syntax");
            IEnumerable<Student> query = students.Where(s => s.LastName == "Smith");
            foreach (var item in query)
            {
                Console.WriteLine(item.FirstName);
            }
        }



    }
}
