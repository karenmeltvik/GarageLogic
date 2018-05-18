using System;

namespace Ex03.GarageLogic
{
    public enum eFuelType { Solar, Octane95, Octane96, Octane98 }

    public class FuelBase : EnergySystem
    {
        private eFuelType m_FuelType;
        public eFuelType FuelType { get; set; }

        public FuelBase(float i_maxAmountOfEnergy, eFuelType i_fuelType) : base(i_maxAmountOfEnergy)
        {
            m_FuelType = i_fuelType;
        }

        public void Refuel(float i_litersToAdd, eFuelType i_fuelType)
        {
            if (i_fuelType != FuelType) throw new ArgumentException("Wrong type of fuel");
            RefillEnergy(i_litersToAdd);
        }
    }
}
