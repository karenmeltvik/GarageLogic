using System;

namespace Ex03.GarageLogic
{
    public class EnergySystem
    {
        private float m_CurrentAmountOfEnergy;
        public float CurrentAmountOfEnergy { get; set; }

        private float m_MaxAmountOfEnergy;
        public float MaxAmountOfEnergy { get; set; }

        public EnergySystem(float i_maxAmountOfEnergy)
        {
            m_MaxAmountOfEnergy = i_maxAmountOfEnergy;
        }

        public void RefillEnergy(float i_refillAmount)
        {
            if (i_refillAmount + CurrentAmountOfEnergy > MaxAmountOfEnergy) { throw new ValueOutOfRangeException(0, MaxAmountOfEnergy); }
            m_CurrentAmountOfEnergy += i_refillAmount;
        }
    }
}
