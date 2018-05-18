using System;

namespace Ex03.GarageLogic
{
    public class ElectricBase : EnergySystem
    {
        public ElectricBase(float i_maxAmountOfEnergy) : base(i_maxAmountOfEnergy)
        {

        }

        public void Recharge(float i_hoursToAdd)
        {
            RefillEnergy(i_hoursToAdd);
        }
    }
}
