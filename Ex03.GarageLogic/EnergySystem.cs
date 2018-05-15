using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex03
{
    public class EnergySystem
    {
        private float m_CurrentAmountOfEnergy;
        private float m_MaxAmountOfEnergy;

        public EnergySystem()
        {

        }

        public void RefillEnergy(float i_refillAmount)
        {
            if (i_refillAmount + m_CurrentAmountOfEnergy > m_MaxAmountOfEnergy) { throw new ValueOutOfRangeException(0, m_MaxAmountOfEnergy); }
            m_CurrentAmountOfEnergy += i_refillAmount;
        }
    }
}
