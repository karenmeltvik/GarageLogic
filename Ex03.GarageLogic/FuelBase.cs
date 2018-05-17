using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class FuelBase : EnergySystem
    {
        public enum eFuelType { Solar, Octane95, Octane96, Octane98 }
        private eFuelType m_FuelType;
        public eFuelType FuelType { get; set; }
        private Vehicle m_Vehicle;

        public FuelBase(float i_maxAmountOfEnergy, eFuelType i_fuelType) : base(i_maxAmountOfEnergy)
        {
            FuelType = i_fuelType;
        }

        public void Refuel(float i_litersToAdd, eFuelType i_fuelType)
        {
            if (i_fuelType != FuelType) throw new ArgumentException("Wrong type of fuel");
            RefillEnergy(i_litersToAdd);
        }
    }
}
