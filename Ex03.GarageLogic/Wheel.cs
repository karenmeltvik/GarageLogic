using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex03
{
    public class Wheel
    {
        private string m_ManufacturerName;
        public string ManufacturerName { get; set; }

        private float m_CurrentAirPressure;
        public float CurrentAirPressure { get; set; }

        private float m_MaxAirPrRecommended;
        public float MaxAirPressure { get; set; }


        public Wheel(string i_manufacturerName, float i_currentAirPressure, float i_maxAirPrRecommended)
        {
            ManufacturerName = i_manufacturerName;
            CurrentAirPressure = i_currentAirPressure;
            MaxAirPressure = i_maxAirPrRecommended;
        }

        public void InflateAction(float i_airToAdd)
        {
            if (CurrentAirPressure + i_airToAdd <= MaxAirPressure)
            {
                CurrentAirPressure += i_airToAdd;
            }
            else
            {
                throw new ValueOutOfRangeException(0, MaxAirPressure);
            }
        }
    }
}
