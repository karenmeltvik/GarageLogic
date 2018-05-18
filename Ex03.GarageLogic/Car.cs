using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public enum eColor { Gray, Blue, White, Black }
    public enum eNumOfDoors { Two = 2, Three = 3, Four = 4, Five = 5 }

    public class Car : Vehicle
    {
        private eColor m_CarColor;
        public eColor CarColor { get; set; }
        private eNumOfDoors m_NumOfDoors;
        public eNumOfDoors NumOfDoors { get; set; }

        public Car(string i_ModelName, string i_LicenseNumber, string i_OwnerName,
                   string i_OwnerPhoneNumber, List<Wheel> i_wheels, eColor i_CarColor, eNumOfDoors i_NumOfDoors, EnergySystem i_energySystem)
            : base(i_ModelName, i_LicenseNumber, i_OwnerName, i_OwnerPhoneNumber, i_wheels, i_energySystem)
        {
            m_CarColor = i_CarColor;
            m_NumOfDoors = i_NumOfDoors;
        }

        public override string ToString()
        {
            StringBuilder infoOfCar = new StringBuilder();
            infoOfCar.AppendLine("Type of vehicle : Car");
            infoOfCar.AppendLine("Color of the car : " + m_CarColor.ToString());
            infoOfCar.AppendLine("Number of doors : " + m_NumOfDoors.ToString());
            return infoOfCar.ToString();
        }
    }
}
