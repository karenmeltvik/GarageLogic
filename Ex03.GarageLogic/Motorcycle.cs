using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Motorcycle : Vehicle
    {
        public enum eLicenseType { A, A1, B1, B2 }
        private eLicenseType m_LicenseType;
        public eLicenseType LicenseType { get; set; }

        private int m_EngineVolume;
        public int EngineVolume { get; set; }

        public Motorcycle(string i_modelName, string i_licenseNumber, float i_remainingEnergyPercentage, eLicenseType i_licenseType, int i_engineVolume)
            : base(i_modelName, i_licenseNumber, i_remainingEnergyPercentage)
        {
            LicenseType = i_licenseType;
            EngineVolume = i_engineVolume;
        }
    }
}
