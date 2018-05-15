using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex03
{
    class Vehicle
    {
        private string m_OwnerName;
        public string OwnerName { get; set; }

        private string m_OwnerPhoneNumber;
        public string OwnerPhoneNumber { get; set; }

        private string m_ModelName;
        public string ModelName { get; set; }

        private string m_LicenseNumber;
        public string LicenseNumber { get; set; }

        private float m_RemainingEnergyPercentage;
        public float RemainingEnergyPercentage { get; set; }

        public enum VehicleStatus { InRepair, Repaired, PaidFor } // how to set this enum to InRepair when adding to garage??
        public VehicleStatus m_Status;

        public Vehicle(string i_modelName, string i_licenseNumber, float i_remainingEnergyPercentage)
        {
            ModelName = i_modelName;
            LicenseNumber = i_licenseNumber;
            RemainingEnergyPercentage = i_remainingEnergyPercentage;
        }
    }

}
