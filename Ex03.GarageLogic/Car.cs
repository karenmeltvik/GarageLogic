using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Car : Vehicle
    {
        public enum eColor { Gray, Blue, White, Black }
        private eColor m_CarColor;
        public eColor CarColor { get; set; }
        public enum eNumOfDoors { Two = 2, Three = 3, Four = 4, Five = 5 }
        private eNumOfDoors m_NumberOfDoors;
        public eNumOfDoors NumberOfDoors { get; set; }

        public Car(string i_modelName, string i_licenseNumber, float i_remainingEnergyPercentage, eColor i_carColor, int i_numberOfDoors)
            : base(i_modelName, i_licenseNumber, i_remainingEnergyPercentage)
        {
            CarColor = i_carColor;
            NumberOfDoors = (eNumOfDoors) i_numberOfDoors;
        }
    }
}
