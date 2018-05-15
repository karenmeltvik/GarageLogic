using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex03
{
    class FuelBase : EnergySystem
    {
        public enum eFuelType { Solar, Octane95, Octane96, Octane98 }
        private eFuelType m_FuelType;
        private Vehicle m_Vehicle;

        public FuelBase()
        {

        }

        public void Refuel(float i_toAdd)
        {
            RefillEnergy(i_toAdd);
        }
    }
}
