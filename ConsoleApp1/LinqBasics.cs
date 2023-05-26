using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics
{
    public class LinqBasic
    {
        public void getLinq()
        {
            Console.WriteLine("Existing .NET Features");
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            foreach (var number in numbers)
            {
                if (number < 3)
                    Console.WriteLine(number);
            }

            Console.WriteLine("Using LINQ");
            // Step 1: Getting data source
            //Data Source need be derived from iEnumarable.
            List<int> numbersLinq = new List<int>() { 1, 2, 3, 4, 5, 6 };

            // Step 2: Writing query
            IEnumerable<int> query = from n in numbersLinq  // Part 1: Data source
                                     where n < 3            // Part 2: Filter    
                                     select n;              // Part 3: Select

            // Step 3: Executing query
            foreach (int number in query)
                Console.WriteLine(number);
        }

        public void FindEvenNumbers()
        {
            Console.WriteLine("Find even numbers");
            // Step 1: Getting data source
            //Data Source need be derived from iEnumarable.
            List<int> inputs = new List<int>() { 1, 2, 3, 4, 5, 6 };

            // Step 2: Writing query
            IEnumerable<int> query = from n in inputs  // Part 1: Data source
                                     where n%2 == 0          // Part 2: Filter    
                                     select n;              // Part 3: Select

            // Step 3: Executing query
            foreach (int number in query)
                Console.WriteLine(number);


        }

        public void linqMethodSyntaxWithoutLamda()
        {
            Console.WriteLine("Using LINQ with Method syntax without lamda");
            // Step 1: Getting data source
            //Data Source need be derived from iEnumarable.
            List<int> inputs = new List<int>() { 1, 2, 3, 4, 5, 6 };

            // Step 2: Writing query
            IEnumerable<int> query = inputs.Where(checkNumber);

            // Step 3: Executing query
            foreach (int number in query)
                Console.WriteLine(number);

        }
         
        static bool checkNumber(int i)
        {
            return i < 3;
        }

        public void linqMethodSyntaxWithLamda()
        {
            Console.WriteLine("Using LINQ with Method syntax with lamda");
            // Step 1: Getting data source
            //Data Source need be derived from iEnumarable.
            List<int> inputs = new List<int>() { 1, 2, 3, 4, 5, 6 };

            // Step 2: Writing query
            IEnumerable<int> query = inputs.Where(i => i < 3);

            // Step 3: Executing query
            foreach (int number in query)
                Console.WriteLine(number);

        }

        public void squareNumberAss2()
        {
            Console.WriteLine("squareNumber Assessment2");
            // Step 1: Getting data source
            //Data Source need be derived from iEnumarable.
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            // Step 2: Writing query
            IEnumerable<int> query = from n in numbers
                                     select n * n;
          
            // Step 2: Writing query
            IEnumerable<int> query2 = numbers.Select(n => n*n);

            Console.WriteLine("Query Syntax");
            // Step 3: Executing query
            foreach (int number in query)
                Console.WriteLine(number);

            Console.WriteLine("Method Syntax");
            foreach (int number in query2)
                Console.WriteLine(number);

        }

    }
}
