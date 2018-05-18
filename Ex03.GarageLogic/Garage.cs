using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Garage
    {
        private Dictionary<string, Vehicle> m_Garage;

        public Garage()
        {
            m_Garage = new Dictionary<string, Vehicle>();
        }

        public bool Contains(string i_LicenseNumber)
        {
            return m_Garage.ContainsKey(i_LicenseNumber);
        }

        public Vehicle FindVehicle(string i_licenseNumber)
        {
            bool isVehicle = m_Garage.TryGetValue(i_licenseNumber, out Vehicle vehicle);
            if (isVehicle) return vehicle;
            return null;
        }

        public void Insert(Vehicle i_VehicleToInsert)
        {
            m_Garage.Add(i_VehicleToInsert.LicenseNumber, i_VehicleToInsert);
        }

        public void DisplayVehicleInformation(string i_LicenseNumber)
        {
            {
                if (!m_Garage.ContainsKey(i_LicenseNumber))
                {
                    throw new VehicleNotFoundException(i_LicenseNumber);
                }
                else
                {
                    Vehicle VehicleToDisplay = m_Garage[i_LicenseNumber];
                    VehicleToDisplay.DisplayInformation();
                }
            }
        }
        public void ChangeStatus(string i_LicenseNumber, eStatus i_NewStatus)
        {
            if (!m_Garage.ContainsKey(i_LicenseNumber))
            {
                throw new VehicleNotFoundException(i_LicenseNumber);
            }
            else
            {
                Vehicle VehicleToChangeStatus = m_Garage[i_LicenseNumber];
                VehicleToChangeStatus.Status = i_NewStatus;
            }
        }

        public void InflatesTiresToMax(string i_LicenseNumber)
        {
            if (!m_Garage.ContainsKey(i_LicenseNumber))
            {
                throw new VehicleNotFoundException(i_LicenseNumber);
            }
            else
            {
                foreach (Wheel wheel in m_Garage[i_LicenseNumber].Wheels)
                {
                    wheel.InflateAction(wheel.MaxAirPressure);
                }
            }
        }

        public void DisplayAllLicenseNbrs()
        {
            StringBuilder inRepairLicences = new StringBuilder();
            inRepairLicences.AppendLine("Vehicles in Repair : ");
            StringBuilder paidForLicences = new StringBuilder();
            paidForLicences.AppendLine("Paid Vehicles: ");
            StringBuilder reparedLicences = new StringBuilder();
            reparedLicences.AppendLine("Repared Vehicles : ");

            foreach (KeyValuePair<string, Vehicle> vehicles in m_Garage)
            {
                if (vehicles.Value.Status == eStatus.InRepair)
                {
                    inRepairLicences.AppendLine(vehicles.Key);
                }
                else if (vehicles.Value.Status == eStatus.PayedFor)
                {
                    paidForLicences.AppendLine(vehicles.Key);
                }
                else if (vehicles.Value.Status == eStatus.Repaired)
                {
                    reparedLicences.AppendLine(vehicles.Key);
                }

            }
            Console.WriteLine(inRepairLicences);
            Console.WriteLine(paidForLicences);
            Console.WriteLine(reparedLicences);
        }

        public void ChargeElectricVehicle(string i_LicenseNumber, float i_HoursToAdd)
        {
            Vehicle vehicle = FindVehicle(i_LicenseNumber);
            ElectricBase electricBase = (ElectricBase)vehicle.EnergySystem;
            electricBase.RefillEnergy(i_HoursToAdd);
            vehicle.RemainingEnergyPercentage = (electricBase.CurrentAmountOfEnergy / electricBase.MaxAmountOfEnergy) * 100;
        }


        public void RefuelVehicle(string i_LicenseNumber, float i_AmountToFill, eFuelType i_fuelType)
        {
            Vehicle vehicle = FindVehicle(i_LicenseNumber);
            FuelBase fuelBase = (FuelBase) vehicle.EnergySystem;
            eFuelType fuelType = fuelBase.FuelType;
            if (i_fuelType != fuelType) throw new ArgumentException("Wrong type of fuel");
            fuelBase.RefillEnergy(i_AmountToFill);
            vehicle.RemainingEnergyPercentage = (fuelBase.CurrentAmountOfEnergy / fuelBase.MaxAmountOfEnergy) * 100;
        }
    }
}
