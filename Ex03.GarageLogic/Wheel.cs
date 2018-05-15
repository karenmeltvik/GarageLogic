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
        public string ManufacturerName
        {
            get { return m_ManufacturerName; }
        }

        private float m_CurrentAirPressure;
        public float CurrentAirPressure
        {
            get { return m_CurrentAirPressure; }
        }

        private float m_MaxAirPrRecommended;
        public float MaxAirPr
        {
            get { return m_MaxAirPrRecommended; }
        }


        public Wheel(string i_manufacturerName, float i_currentAirPressure, float i_maxAirPrRecommended)
        {
            this.m_ManufacturerName = i_manufacturerName;
            this.m_CurrentAirPressure = i_currentAirPressure;
            this.m_MaxAirPrRecommended = i_maxAirPrRecommended;


        }
        public void InflateAction(float i_airToAdd)
        {
            if (m_CurrentAirPressure + i_airToAdd <= m_MaxAirPrRecommended)
            {
                this.m_CurrentAirPressure += i_airToAdd;
            }
            else
            {
                throw new ArgumentException("More air than the maximum possible");
            }
        }
    }
}
