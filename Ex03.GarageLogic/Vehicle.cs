using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Vehicle
    {
        private string m_ModelName;
        public string ModelName { get; set; }

        private string m_LicenseNumber;
        public string LicenseNumber { get; set; }

        private float m_RemainingEnergyPercentage;
        public float RemainingEnergyPercentage { get; set; }

        public Vehicle(string i_modelName, string i_licenseNumber, float i_remainingEnergyPercentage)
        {
            ModelName = i_modelName;
            LicenseNumber = i_licenseNumber;
            RemainingEnergyPercentage = i_remainingEnergyPercentage;
        }
    }

}
