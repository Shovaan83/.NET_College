using ConsoleApp.Week_6;
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

            Rectangle rect = new Rectangle { Width = 5, Height = 10 };
            Console.WriteLine(rect);

            Console.WriteLine();

            Console.WriteLine("Task 2:");

            Calculate calc = DiscountCalculator.Add;
            Console.WriteLine($"Add(10, 5) = {calc(10, 5)}");

            calc = DiscountCalculator.Subtract;
            Console.WriteLine($"Subtract(10, 5) = {calc(10, 5)}");
            Console.WriteLine();

            double originalPrice = 5000;
            Console.WriteLine($"Original Price: Rs. {originalPrice}");

            double festivalPrice = DiscountCalculator.CalculateFinalPrice(originalPrice, DiscountCalculator.FestivalDiscount);
            Console.WriteLine($"Festival Discount (20% off): Rs. {festivalPrice}");

            double seasonalPrice = DiscountCalculator.CalculateFinalPrice(originalPrice, DiscountCalculator.SeasonalDiscount);
            Console.WriteLine($"Seasonal Discount (10% off): Rs. {seasonalPrice}");

            double noDiscountPrice = DiscountCalculator.CalculateFinalPrice(originalPrice, DiscountCalculator.NoDiscount);
            Console.WriteLine($"No Discount: Rs. {noDiscountPrice}");

            double lambdaPrice = DiscountCalculator.CalculateFinalPrice(originalPrice, price => price * 0.70);
            Console.WriteLine($"Lambda Discount (30% off): Rs. {lambdaPrice}");

            Console.WriteLine();

            Console.WriteLine("Task 3:");

            int[] numbers = { 5, 12, 8, 21, 3, 16, 7 };

            Console.WriteLine("All numbers: " + string.Join(", ", numbers));

            Console.Write("Even numbers: ");
            ProcessNumbers(numbers, n => n % 2 == 0);

            Console.Write("Numbers greater than 10: ");
            ProcessNumbers(numbers, n => n > 10);

            static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
            {
                var result = numbers.Where(condition);
                Console.WriteLine(string.Join(", ", result));
            }

            Console.WriteLine();

            Console.WriteLine("Task 4:");

            Console.WriteLine("1. Selecting/Projection");
            List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
            var squaredNumbers = intList.Select(n => n * n).ToList();
            Console.WriteLine("Original: " + string.Join(", ", intList));
            Console.WriteLine("Squared: " + string.Join(", ", squaredNumbers));
            Console.WriteLine();

            Console.WriteLine("2. Filtering (Where)");
            List<Book> books = new List<Book>
            {
                new Book { Title = "C# Programming", Price = 1500 },
                new Book { Title = "Learn Python", Price = 800 },
                new Book { Title = "Advanced Java", Price = 1200 },
                new Book { Title = "Web Design", Price = 950 },
                new Book { Title = "Data Structures", Price = 1800 }
            };

            var premiumBooks = books.Where(b => b.Price > 1000).ToList();
            Console.WriteLine("Premium Books (Price > Rs. 1000):");
            premiumBooks.ForEach(b => Console.WriteLine($"  {b}"));
            Console.WriteLine();

            Console.WriteLine(" 3. Sorting (OrderBy)");
            List<Student> students = new List<Student>
            {
                new Student { Name = "Shovan" },
                new Student { Name = "Himal" },
                new Student { Name = "Kamal" },
                new Student { Name = "Arpan" }
            };

            var sortedStudents = students.OrderBy(s => s.Name).ToList();
            Console.WriteLine("AAA Scholarship Award Winners (Alphabetically):");
            sortedStudents.ForEach(s => Console.WriteLine($"  {s}"));
            Console.WriteLine();

            Console.WriteLine("Task 5:");

            Console.WriteLine("1. Aggregation Operators");
            List<CashierSales> salesData = new List<CashierSales>
            {
                new CashierSales { CashierName = "Shovan", Sales = 15000 },
                new CashierSales { CashierName = "Arpan", Sales = 22000 },
                new CashierSales { CashierName = "Himal", Sales = 18000 },
                new CashierSales { CashierName = "Kamal", Sales = 12000 },
            };

            int totalCashiers = salesData.Count();
            double totalSales = salesData.Sum(c => c.Sales);
            double highestSales = salesData.Max(c => c.Sales);
            double lowestSales = salesData.Min(c => c.Sales);
            double averageSales = salesData.Average(c => c.Sales);

            Console.WriteLine($"Total Cashiers: {totalCashiers}");
            Console.WriteLine($"Total Sales: Rs. {totalSales}");
            Console.WriteLine($"Highest Sales: Rs. {highestSales}");
            Console.WriteLine($"Lowest Sales: Rs. {lowestSales}");
            Console.WriteLine($"Average Sales: Rs. {averageSales}");
            Console.WriteLine();

            Console.WriteLine("2. Quantifier Operators (Any/All)");
            List<Applicant> applicants = new List<Applicant>
            {
                new Applicant { Name = "Shovan", Age = 20 },
                new Applicant { Name = "Himal", Age = 20 },
                new Applicant { Name = "Kamal", Age = 25 },
                new Applicant { Name = "Arpan", Age = 21 }
            };

            bool anyUnder18 = applicants.Any(a => a.Age < 18);
            bool allAbove16 = applicants.All(a => a.Age >= 16);

            Console.WriteLine($"Are there any applicants under 18? {anyUnder18}");
            Console.WriteLine($"Are all applicants above 16? {allAbove16}");
            Console.WriteLine();

            Console.WriteLine("3. Element Operators");
            List<Song> songs = new List<Song>
            {
                new Song { Title = "Not Like Us", DurationInSeconds = 180 },
                new Song { Title = "RING RING RING", DurationInSeconds = 300 },
                new Song { Title = "Wait for You", DurationInSeconds = 210 }
            };

            var firstSong = songs.First();
            var lastSong = songs.Last();
            var firstLongSong = songs.First(s => s.DurationInSeconds > 240);
            var firstVeryLongSong = songs.FirstOrDefault(s => s.DurationInSeconds > 600);

            Console.WriteLine($"First Song: {firstSong}");
            Console.WriteLine($"Last Song: {lastSong}");
            Console.WriteLine($"First song > 4 minutes (240s): {firstLongSong}");
            Console.WriteLine($"First song > 10 minutes (600s): {(firstVeryLongSong != null ? firstVeryLongSong.ToString() : "None found")}");
            Console.WriteLine();

            Console.WriteLine("Task 6:");

            List<TourBooking> tourBookings = new List<TourBooking>
            {
                new TourBooking { CustomerName = "Shovan Bhattarai", Destination = "Paris", Price = 45000, DurationInDays = 7, IsInternational = true },
                new TourBooking { CustomerName = "Hiten Bagri", Destination = "Pokhara", Price = 8000, DurationInDays = 3, IsInternational = false },
                new TourBooking { CustomerName = "Kamal Bhandari", Destination = "Tokyo", Price = 55000, DurationInDays = 10, IsInternational = true },
                new TourBooking { CustomerName = "Arpan Uprety", Destination = "Chitwan", Price = 12000, DurationInDays = 5, IsInternational = false },
            };

            var filteredTours = tourBookings
                .Where(t => t.Price > 10000 && t.DurationInDays > 4);

            var transformedTours = filteredTours
                .Select(t => new
                {
                    CustomerName = t.CustomerName,
                    Destination = t.Destination,
                    Category = t.IsInternational ? "International" : "Domestic",
                    Price = t.Price
                });

            var sortedTours = transformedTours
                .OrderBy(t => t.Category)
                .ThenBy(t => t.Price)
                .ToList();

            Console.WriteLine("Market Analysis Report - Premium Tours (Price > Rs. 10,000 & Duration > 4 days)");
            Console.WriteLine("=".PadRight(80, '='));

            foreach (var tour in sortedTours)
            {
                Console.WriteLine($"Customer: {tour.CustomerName}");
                Console.WriteLine($"Destination: {tour.Destination}");
                Console.WriteLine($"Category: {tour.Category}");
                Console.WriteLine($"Price: Rs. {tour.Price}");
                Console.WriteLine("-".PadRight(80, '-'));
            }

            Console.ReadLine();
        }
    }
}
