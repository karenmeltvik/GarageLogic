using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Motorcycle : Vehicle
    {
        public enum eLicenseType { A, A1, B1, B2 }
        private eLicenseType m_LicenseType;
        public eLicenseType LicenseType { get; set; }

        private int m_EngineVolume;
        public int EngineVolume { get; set; }

        public Motorcycle(string i_ModelName, string i_LicenseNumber, string i_OwnerName,
                          string i_OwnerPhoneNumber, List<Wheel> i_wheels, eLicenseType i_licenseType, int i_engineVolume)
            : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber, i_wheels)
        {
            m_LicenseType = i_licenseType;
            m_EngineVolume = i_engineVolume;
        }
    }
}
