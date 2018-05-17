using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Truck : Vehicle
    {
        private bool m_IsCooled;
        private float m_CargoVolume;
        public float CargoVolume { get; set; }

        public Truck(string i_modelName, string i_licenseNumber, float i_remainingEnergyPercentage, float i_cargoVolume)
            : base(i_modelName, i_licenseNumber, i_remainingEnergyPercentage)
        {
            CargoVolume = i_cargoVolume;
        }
    }
}
