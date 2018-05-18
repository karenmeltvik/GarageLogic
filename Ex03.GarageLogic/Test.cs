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
            FuelBase fueled = new FuelBase(205, eFuelType.Octane96);
            Truck truck = new Truck("Volvo", "3232", "Karen", "05722451", wheels, true, 2000, fueled);
            Car car = new Car("Hyundai", "3333333", "Karen", "0847372", wheels, eColor.Blue, eNumOfDoors.Two, fueled);
            Motorcycle jaja = new Motorcycle("suzuki", "343", "jonas", "0537085642", wheels, Motorcycle.eLicenseType.B1, 130, fueled);
            m_Garage.Insert(car);
            m_Garage.Insert(jaja);
            m_Garage.Insert(truck);
            truck.Wheels.First().InflateAction(20);
            m_Garage.DisplayVehicleInformation(truck.LicenseNumber);
        }
    }
}