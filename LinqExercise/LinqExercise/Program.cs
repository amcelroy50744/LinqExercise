using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers
            var sum = numbers.Sum();
            Console.WriteLine($"Here's my sum:{sum}");
            
            var average = numbers.Average();
            
            Console.WriteLine($"Here's my average: {average}");

            //Order numbers in ascending order and decsending order. Print each to console.
            var ascending = numbers.OrderBy(i => i);
            Console.WriteLine("Going up!");
            foreach (var x in ascending) 
            {
                Console.WriteLine($"{x}");
            }

            var descend = numbers.OrderByDescending(k => k);
            Console.WriteLine("Going down!");
            foreach (var d in descend) 
            {
                Console.WriteLine($"{d}");
            }
            //Print to the console only the numbers greater than 6
            var up6 = numbers.Where(i => (i >= 6));
            Console.WriteLine("Greater than 6 only!");
            foreach (var e in up6) 
            {
                Console.WriteLine($"{e}");
            }

            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Just four acsending!");
            foreach (var num in numbers.Take(4))
            {
                Console.WriteLine(num);
            }


            //Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 30;
            Console.WriteLine("Index 4 to age");
            foreach(var age in numbers.OrderByDescending(num => num))
            {
                Console.WriteLine(age);
            }
            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.
            Console.WriteLine("Fullnames that start with C or S");
            var startsWith = employees.Where(emp => emp.FirstName.StartsWith('C') || emp.FirstName.StartsWith('S')).OrderBy(emp => emp.FirstName);
           
            foreach (var empl in startsWith)
            {
                Console.WriteLine(empl.FullName);
            }

            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Older than 26!");
            var ageFirstN = employees.Where(age => age.Age > 26).OrderBy(age => age.Age).ThenBy(age => age.FirstName);
            
            foreach(var a in ageFirstN)
            {
                Console.WriteLine($" Age: {a.Age} Name:{a.FullName}");
            }

            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            var years = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);

            var sumOfYOE = years.Sum(emp => emp.YearsOfExperience);
            var avgg = years.Average(emp => emp.YearsOfExperience);

            Console.WriteLine($"Sum:{sumOfYOE} Average: {avgg}");

            //Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("Mike", "Jones", 15, 1)).ToList();
            foreach ( var item in employees)
            {
                Console.WriteLine($"Name: {item.FullName}  YOE: {item.YearsOfExperience} Age: {item.Age}");
            }
            
            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
