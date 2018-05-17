using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            MaxAmountOfEnergy = i_maxAmountOfEnergy;
        }

        public void RefillEnergy(float i_refillAmount)
        {
            if (i_refillAmount + CurrentAmountOfEnergy > MaxAmountOfEnergy) { throw new ValueOutOfRangeException(0, MaxAmountOfEnergy); }
            CurrentAmountOfEnergy += i_refillAmount;
        }
    }
}
