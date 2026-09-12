using System;

namespace ComputerRepairManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Computer Repair Management System");

            Console.WriteLine("Enter 1 - for Technician Login");
            Console.WriteLine("Enter 2 - for Customer Login");
            Console.WriteLine("Enter x - to exit");

            Console.Write("User Input: ");

            string techID = "TECH101";
            string checkLogin = Console.ReadLine()?.Trim();

            // Default ticket record details
            string ticketNumber = "REP-2026-001";
            string customerName = "Mark John";
            string deviceModel = "Dell XPS 15";
            string repairStatus = "Diagnosing";
            double estimatedCost = 150.00;

            while (checkLogin != "x" && checkLogin != "X")
            {
                if (checkLogin == "1")
                {
                    Console.Write("Enter Technician ID: ");
                    string techInput = Console.ReadLine()?.Trim();

                    if (techInput == techID)
                    {
                        Console.Write("Enter Repair Ticket Number to update: ");
                        string checkTicket = Console.ReadLine()?.Trim();

                        if (checkTicket == ticketNumber)
                        {
                            Console.WriteLine($"\nUpdating Ticket: {ticketNumber} ({customerName} - {deviceModel})");
                            Console.WriteLine("Select New Status:");
                            Console.WriteLine("1 - In Progress");
                            Console.WriteLine("2 - Awaiting Parts");
                            Console.WriteLine("3 - Ready for Pickup");
                            Console.Write("Enter option: ");

                            string statusChoice = Console.ReadLine()?.Trim();

                            switch (statusChoice)
                            {
                                case "1":
                                    repairStatus = "In Progress";
                                    Console.WriteLine("Status updated to: In Progress");
                                    break;
                                case "2":
                                    repairStatus = "Awaiting Parts";
                                    Console.WriteLine("Status updated to: Awaiting Parts");
                                    break;
                                case "3":
                                    repairStatus = "Ready for Pickup";
                                    Console.WriteLine("Status updated to: Ready for Pickup");
                                    break;
                                default:
                                    Console.WriteLine("Invalid option. Status unchanged.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ticket number not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Technician ID.");
                    }
                }
                else if (checkLogin == "2")
                {
                    Console.Write("Enter your Repair Ticket Number: ");
                    string userInput = Console.ReadLine()?.Trim();
                    bool response = userInput == ticketNumber;

                    if (response)
                    {
                        Console.WriteLine($"\nWelcome, {customerName}!");

                        Console.WriteLine("Type 1 - to view repair status");
                        Console.WriteLine("Type 2 - to view estimated cost");
                        Console.WriteLine("Type 3 - to exit to main menu");

                        Console.Write("Enter your option: ");

                        if (int.TryParse(Console.ReadLine(), out int choice))
                        {
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine($"\n[Ticket: {ticketNumber}] Device: {deviceModel} | Status: {repairStatus}");
                                    break;
                                case 2:
                                    Console.WriteLine($"\n[Ticket: {ticketNumber}] Estimated Repair Cost: ${estimatedCost:F2}");
                                    break;
                                case 3:
                                    Console.WriteLine("Logging out...");
                                    break;
                                default:
                                    Console.WriteLine("Incorrect input...");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ticket number not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid menu selection.");
                }

                Console.WriteLine("\n-------------------------------------------");
                Console.WriteLine("Enter 1 - for Technician Login");
                Console.WriteLine("Enter 2 - for Customer Login");
                Console.WriteLine("Enter x - to exit");
                Console.Write("User Input: ");
                checkLogin = Console.ReadLine()?.Trim();
            }

            Console.WriteLine("\nThank you for using Computer Repair Management System!");
        }
    }
}