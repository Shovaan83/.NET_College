using ConsoleApp.Week_5;
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

            BankAccount account = new BankAccount("ACCOUNTNUM1", 1200);
            Console.WriteLine($"Account Number: {account.accountNum}");
            Console.WriteLine($"Initial Balance: NPR{account.Balance}");

            account.Deposit(1500);

            account.Withdraw(3300);

            Console.WriteLine($"Final Balance: NPR{account.Balance}");

            Console.WriteLine();

            Console.WriteLine("Task 2:");

            Car car = new Car { Brand = "Nissan", Speed = 180, Seats = 5 };
            car.Start();
            car.DisplayInfo();
            car.Stop();
            Console.WriteLine();

            Motorcycle motorcycle = new Motorcycle { Brand = "TVS", Speed = 200, Type = "Sport" };
            motorcycle.Start();
            motorcycle.DisplayInfo();
            motorcycle.Stop();
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Task 3:");

            Printer printer = new Printer();
            printer.Print("Hello, I am Shovan");
            printer.Print(42);
            printer.Print("Important", 3);
            Console.WriteLine();


            NepaliTeacher nepaliTeacher = new NepaliTeacher { Name = "Bhanubhakta Acharya" };
            Console.WriteLine($"Teacher Name: {nepaliTeacher.Name}");
            nepaliTeacher.Teaching();
            nepaliTeacher.SalaryInfo();
            Console.WriteLine();

            EnglishTeacher englishTeacher = new EnglishTeacher { Name = "Prince Harry" };
            Console.WriteLine($"Teacher Name: {englishTeacher.Name}");
            englishTeacher.Teaching();
            englishTeacher.SalaryInfo();
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Task 4:");

            ACar abstractCar = new ACar();
            abstractCar.Display();
            abstractCar.StartEngine();
            abstractCar.StopEngine();
            Console.WriteLine();

            Bike bike = new Bike();
            bike.Display();
            bike.StartEngine();
            bike.StopEngine();
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Task 5:");

            ElectronicStore store = new ElectronicStore();

            Laptop laptop1 = new Laptop("Asus", 120000);
            Laptop laptop2 = new Laptop("HP", 95000);
            Smartphone phone1 = new Smartphone("Apple", 175000);
            Smartphone phone2 = new Smartphone("Samsung", 140000);

            store.AddDevice(laptop1);
            store.AddDevice(laptop2);
            store.AddDevice(phone1);
            store.AddDevice(phone2);

            store.ShowAllDeviceDetails();

            Console.ReadLine();
          }

    }
}
