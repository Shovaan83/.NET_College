using ConsoleApp.Week_4;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Task 1:");
            Student One = new Student();
            One.Name = "Shovan Bhattarai";
            One.Age = 20;
            One.Address = "Itahari, Sunsari";

            Student Two = new Student();
            Two.Name = "Himal Neupane";
            One.Age = 21;
            Two.Address = "Bargachi, Birtatnagar";

            Console.WriteLine("Student One Info:");
            Console.WriteLine($"Name: {One.Name}, Age: {One.Age}, Address: {One.Address}, Father Name: {Student.FatherName}");

            Console.WriteLine("Student Two Info:");
            Console.WriteLine($"Name: {Two.Name}, Age: {Two.Age}, Address: {Two.Address}, Father Name: {Student.FatherName}");

            Console.WriteLine();

            Console.WriteLine("Task 2:");

            static void RunCalculator()
            {
                Calculator calc = new Calculator();

                calc.PrintWelcome();

                int sum = calc.Add(10, 30);
                Console.WriteLine($"Add: {sum} ");

                int multiply = calc.Multiply(30, 40);
                Console.WriteLine($"Multiply: {multiply}");
            }

            Console.WriteLine();
            RunCalculator();

            Console.WriteLine();

            Console.WriteLine("Task 3:");
            static void RunParameterDemo()
            {
                ParameterDemo demo = new ParameterDemo();

                int value = 5;
                Console.WriteLine($"Original value: {value}");
                demo.Increase(ref value);
                Console.WriteLine($"After Increase(ref): {value}");

                demo.GetFullName(out string fullName);
                Console.WriteLine($"Full name from out parameter: {fullName}");

                int total1 = demo.SumAll(4, 10, 18, 19, 5);
                int total2 = demo.SumAll(10, 20);
                Console.WriteLine($"SumAll(1,2,3,4,5) = {total1}");
                Console.WriteLine($"SumAll(10,20) = {total2}");
            }
            RunParameterDemo();

            Console.WriteLine();

            Console.WriteLine("Task 4:");

            static void RunPlayer()
            {
                Player p1 = new Player();
                Console.WriteLine($"Player 1: Name: {p1.PlayerName}, Level: {p1.Level}, Health: {p1.Health}");

                Player p2 = new Player("Denish", 10, 180);
                Console.WriteLine ($"Player 2: Name: {p2.PlayerName}, Level: {p2.Level}, Health: {p2.Health}");
            }
            RunPlayer();

            Console.WriteLine();

            Console.WriteLine("Task 5:");
            static void RunEnumRecord()
            {
                Console.Write("Enter a day of the week: ");
                string dayInput = Console.ReadLine();

                DayType dayType;

                if (dayInput.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
                    dayInput.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
                {
                    dayType = DayType.Weekend;
                }
                else
                {
                    dayType = DayType.Weekday;
                }

                Console.WriteLine($"It is: {dayType}");

                Book book1 = new Book("Clean Code", "Robert C. Martin", 999.0);

                Book book2 = book1 with { title = "Clean Architecture", price = 1099.0 };

                Console.WriteLine("\nFirst book object:");
                Console.WriteLine(book1);

                var (title, author, price) = book2;
                Console.WriteLine("\nDeconstructed second book:");
                Console.WriteLine($"Title: {title}");
                Console.WriteLine($"Author: {author}");
                Console.WriteLine($"Price: {price}");
            }
            RunEnumRecord();

            Console.WriteLine();

            Console.WriteLine("Task 6:");
            static void RunDebugging()
            {
                Console.WriteLine("Enter the marks obtained: ");
                string markInput = Console.ReadLine();

                Console.WriteLine("Enter the total marks: ");
                string totalMarks = Console.ReadLine();

               if (!int.TryParse(markInput, out int marks))
                {
                    Console.WriteLine("The input is invalid for marks.");
                    return;
                }

               if (!int.TryParse(totalMarks, out int total))
                {
                    Console.WriteLine("The input is invalid for total marks");
                    return;
                }

               if (total == 0)
                {
                    Console.WriteLine("The total marks can't be zero");
                    return;
                }

                // WRONG (for discussion): double percentage = marks / total * 100;
                // Reason: marks/total is a integer division. 

                double percentage = (double)marks / total * 100.0;
                Console.WriteLine($"Percentage = {percentage}%");

            }
            RunDebugging();

            Console.WriteLine();

            Console.ReadLine();
        }

    }
}
