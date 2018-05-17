using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03;

namespace Ex03.GarageLogic
{
    class Test
    {
        public static void Main()
        {
            Garage m_Garage = new Garage();
            Wheel a = new Wheel("jonascompany", 100, 120);
            Wheel b = new Wheel("KarenCompany", 20, 102);
            List<Wheel> wheels = new List<Wheel>();
            wheels.Add(a);
            wheels.Add(b);
            FuelBase fueled = new FuelBase(25, eFuelType.Octane96);
            Car car = new Car("Hyundai", "3333333", "Karen", "0847372", wheels, eColor.Blue, eNumOfDoors.Two, fueled);
            Motorcycle jaja = new Motorcycle("suzuki", "343", "jonas", "0537085642", wheels, Motorcycle.eLicenseType.B1, 130);
            m_Garage.Insert(car);
            m_Garage.Insert(jaja);
            m_Garage.DisplayVehicleInformation("343");
            m_Garage.DisplayVehicleInformation(car.LicenseNumber);
        }
    }
}