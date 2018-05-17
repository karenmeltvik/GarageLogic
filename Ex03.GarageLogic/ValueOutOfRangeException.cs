using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
        private float m_MaxValue { get; }
        private float m_MinValue { get; }
        public ValueOutOfRangeException(float i_MinValue, float i_MaxValue)
            : base(string.Format("Value is not in the range from {0} to {1}", i_MinValue, i_MaxValue))
        { }
    }
}
