using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        private bool m_IsCooled;
        private float m_CargoVolume;
        public float CargoVolume { get; set; }

        public Truck(string i_ModelName, string i_LicenseNumber, string i_OwnerName,
                     string i_OwnerPhoneNumber, List<Wheel> i_wheels, bool i_IsCooled, float i_CargoVolume)
            : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber, i_wheels)
        {
            m_IsCooled = i_IsCooled;
            m_CargoVolume = i_CargoVolume;
        }
    }
}
