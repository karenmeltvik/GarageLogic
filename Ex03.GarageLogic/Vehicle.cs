using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public enum eStatus
    {
        InRepair,
        Repaired,
        PayedFor
    }

    public class Vehicle
    {
        protected readonly string m_ModelName;
        public string ModelName
        {
            get
            {
                return m_ModelName;
            }
        }

        protected readonly string m_LicenseNumber;
        public string LicenseNumber
        {
            get
            {
                return m_LicenseNumber;
            }
        }
        protected float m_RemainingEnergyPercentage;
        protected List<Wheel> m_Wheels;
        public List<Wheel> Wheels { get { return m_Wheels; } }
        protected string m_OwnerName;
        protected string m_OwnerPhoneNumber;
        protected eStatus m_Status = eStatus.InRepair;
        public eStatus Status
        {
            get
            {
                return m_Status;
            }
            set
            {
                m_Status = value;
            }
        }
        protected EnergySystem m_EnergySystem;
        public EnergySystem EnergySystem
        {
            get { return m_EnergySystem; }
            set { m_EnergySystem = value; }
        }

        public Vehicle(string i_ModelName, string i_LicenseNumber, string i_Owner, string i_OwnerPhoneNumber, List<Wheel> i_wheels, EnergySystem i_energySystem)
        {
            m_LicenseNumber = i_LicenseNumber;
            m_ModelName = i_ModelName;
            m_OwnerName = i_Owner;
            m_OwnerPhoneNumber = i_OwnerPhoneNumber;
            m_Wheels = i_wheels;
            EnergySystem = i_energySystem;
        }

        public void DisplayInformation()
        {
            StringBuilder informations = new StringBuilder();
            informations.AppendLine("License number : " + this.LicenseNumber);
            informations.AppendLine("Model Name : " + this.m_ModelName);
            informations.AppendLine("Owner Name : " + this.m_OwnerName);
            informations.AppendLine("Status : " + this.m_Status);
            int i = 1;
            if (EnergySystem is FuelBase)
            {
                FuelBase fuelBase = (FuelBase) EnergySystem;
                informations.AppendLine("Fuel type: " + fuelBase.FuelType);
                informations.AppendLine("Remaining fuel percentage: " + m_RemainingEnergyPercentage);
            }
            else if (EnergySystem is ElectricBase)
            {
                informations.AppendLine("Remaining battery percentage: " + m_RemainingEnergyPercentage);
            }
            else
            {
                informations.AppendLine("Remaining energy percentage: " + m_RemainingEnergyPercentage);
            }
            foreach (Wheel wheel in m_Wheels)
            {
                informations.AppendLine("Manufacturer Name of wheel " + i + " : " + wheel.ManufacturerName);
                informations.AppendLine("Air pressure of wheel " + i + " : " + wheel.CurrentAirPressure);
                i++;
            }
            Console.WriteLine(informations);
        }

        public void Refuel(float i_amountOfFuel, eFuelType i_fuelType)
        {
            if (EnergySystem is FuelBase)
            {
                EnergySystem.RefillEnergy(i_amountOfFuel);
            }
        }
    }

}
