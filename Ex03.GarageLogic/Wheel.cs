using System;

namespace Ex03.GarageLogic
{
    public class Wheel
    {
        private string m_ManufacturerName;
        public string ManufacturerName { get; set; }

        private float m_CurrentAirPressure;
        public float CurrentAirPressure
        {
            get { return m_CurrentAirPressure; }
        }

        private float m_MaxAirPrRecommended;
        public float MaxAirPressure { get; set; }


        public Wheel(string i_manufacturerName, float i_currentAirPressure, float i_maxAirPrRecommended)
        {
            ManufacturerName = i_manufacturerName;
            m_CurrentAirPressure = i_currentAirPressure;
            MaxAirPressure = i_maxAirPrRecommended;
        }

        public void InflateAction(float i_airToAdd)
        {
            if (m_CurrentAirPressure + i_airToAdd <= MaxAirPressure)
            {
                m_CurrentAirPressure += i_airToAdd;
            }
            else
            {
                throw new ValueOutOfRangeException(0, MaxAirPressure);
            }
        }
    }
}
