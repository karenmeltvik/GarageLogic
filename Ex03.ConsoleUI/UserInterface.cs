using System;
using System.Collections.Generic;
using System.Linq;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class UserInterface
    {

        public enum eVehicleTypes { Car, Motorcycle, Truck }

        private static readonly Garage sr_Garage = new Garage();

        public static void Main()
        {
            Console.WriteLine("Welcome to the garage. There are currently no vehicles.");
            int command;
            Menu();
            bool isRead = Int32.TryParse(Console.ReadLine(), out command);
            while (command != 8) {
                while (!isRead)
                {
                    Console.WriteLine("Please try again, write a number");
                    isRead = Int32.TryParse(Console.ReadLine(), out command);
                }
                if (command == 8) return;
                ParseCommand(command);
                Menu();
                isRead = Int32.TryParse(Console.ReadLine(), out command);
            }
        }

        public static void Menu()
        {
            Console.WriteLine("What would you like to do? Write the given number and press enter:");
            Console.WriteLine("1. Add a new vehicle");
            Console.WriteLine("2. Display a list of license numbers in the garage");
            Console.WriteLine("3. Change a vehicle's status");
            Console.WriteLine("4. Inflate a vehicle's tires to maximum");
            Console.WriteLine("5. Refuel a fuel-based vehicle");
            Console.WriteLine("6. Charge an electric-based vehicle");
            Console.WriteLine("7. Display vehicle information");
            Console.WriteLine("8. Exit");
        }

        public static void ParseCommand(int i_command)
        {
            switch (i_command)
            {
                case 1:
                    AddVehicle();
                    break;
                case 2:
                    ListLicenseNumbers();
                    break;
                case 3:
                    ChangeStatus();
                    break;
                case 4:
                    InflateTires();
                    break;
                case 5:
                    Refuel();
                    break;
                case 6:
                    Charge();
                    break;
                case 7:
                    DisplayInfo();
                    break;
                default:
                    Console.WriteLine("Try a number from 1 to 8.");
                    // fix
                    break;
            }
        }

        public static void AddVehicle()
        {
            Console.WriteLine("Choose a vehicle type: ");
            string[] vehicleTypes = Enum.GetNames(typeof(eVehicleTypes));
            foreach (string type in vehicleTypes)
            {
                Console.WriteLine(type);
            }
            string givenType = Console.ReadLine();
            foreach (string type in vehicleTypes)
            {
                if (givenType == type)
                {
                    //find way to iterate through types without duplicating code
                }
            }
            //Car()
        }

        public static void ListLicenseNumbers()
        {
            sr_Garage.DisplayAllLicenseNbrs();
        }

        private static void PromptForLicenseNumber(out string i_licenseNumber)
        {
            Console.WriteLine("Please write the license number of the vehicle:");
            i_licenseNumber = Console.ReadLine();
            while (!sr_Garage.Contains(i_licenseNumber))
            {
                Console.WriteLine("Please write the license number of a vehicle in the garage.");
                i_licenseNumber = Console.ReadLine();
            }
        }

        public static void ChangeStatus()
        {
            string licenseNumber;
            PromptForLicenseNumber(out licenseNumber);

            Console.WriteLine("Please write the new status of the vehicle:");
            string status = Console.ReadLine();
            eStatus newStatus;
            bool isStatus = Enum.TryParse(status, out newStatus);
            while (!isStatus)
            {
                Console.WriteLine("Please write the new status of the vehicle: either InRepair, Repaired or PayedFor");
                isStatus = Enum.TryParse(status, out newStatus);
            }
            sr_Garage.ChangeStatus(licenseNumber, newStatus);
            Console.WriteLine("The new status of " + licenseNumber + ": " + newStatus);
        }

        public static void InflateTires()
        {
            string licenseNumber;
            PromptForLicenseNumber(out licenseNumber);
            sr_Garage.InflatesTiresToMax(licenseNumber);
            Console.WriteLine("Tires inflated to maximum!");
        }

        public static void Refuel()
        {
            string licenseNumber;
            PromptForLicenseNumber(out licenseNumber);
            Vehicle vehicle = sr_Garage.FindVehicle(licenseNumber);
            while (!(vehicle.EnergySystem is GarageLogic.FuelBase))
            {
                Console.WriteLine("This vehicle is not fuel-driven, try another:");
                PromptForLicenseNumber(out licenseNumber);
                vehicle = sr_Garage.FindVehicle(licenseNumber);
            }
            eFuelType fuelType;
            GetFuelType(out fuelType);
            float amountOfFuel;
            GetRefillAmount(out amountOfFuel);
            vehicle.EnergySystem.RefillEnergy(amountOfFuel);
        }
        
        public static void Charge() //maybe merge with Refuel because they do the same thing just with different types
        {
            string licenseNumber;
            PromptForLicenseNumber(out licenseNumber);
            Vehicle vehicle = sr_Garage.FindVehicle(licenseNumber);
            while (!(vehicle.EnergySystem is GarageLogic.ElectricBase))
            {
                Console.WriteLine("This vehicle is not electric, try another:");
                PromptForLicenseNumber(out licenseNumber);
                vehicle = sr_Garage.FindVehicle(licenseNumber);
            }
            float amountToCharge;
            GetRefillAmount(out amountToCharge);
            vehicle.EnergySystem.RefillEnergy(amountToCharge);
        }

        private static void GetFuelType(out GarageLogic.eFuelType i_fuelType)
        {
            Console.WriteLine("Which fuel type do you want to use?");
            string fuel = Console.ReadLine();
            bool isFuel = Enum.TryParse(fuel, out i_fuelType);
            while (!isFuel)
            {
                Console.WriteLine("That is not a fuel type, try again:");
                fuel = Console.ReadLine();
                isFuel = Enum.TryParse(fuel, out i_fuelType);
            }
        }

        private static void GetRefillAmount(out float i_amountToFill)
        {
            Console.WriteLine("How much energy should be filled?");
            string amount = Console.ReadLine();
            bool isNum = float.TryParse(amount, out i_amountToFill);
            while (!isNum)
            {
                amount = Console.ReadLine();
                isNum = float.TryParse(amount, out i_amountToFill);
            }
        }

        public static void DisplayInfo()
        {
            PromptForLicenseNumber(out string licenseNumber);
            sr_Garage.DisplayVehicleInformation(licenseNumber);
        }
    }
}
