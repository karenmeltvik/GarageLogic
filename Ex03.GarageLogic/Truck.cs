using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex03
{
    class Truck
    {
        private Vehicle m_Vehicle;
        private bool m_IsCooled;
        private float m_CargoVolume;

        public Truck(string i_modelName, string i_licenseNumber, float i_remainingEnergyPercentage)
        {
            m_Vehicle = new Vehicle(i_modelName, i_licenseNumber, i_remainingEnergyPercentage);
        }
    }
}
