using System;

namespace Ex03.GarageLogic
{
    public class WrongFuelTypeException : Exception
    {
        public WrongFuelTypeException(eFuelType i_WrongFuelType, eFuelType i_AppropriateFuelType)
            : base(string.Format("{0} is not the appropriate fuel, it has to be {1}",
                                 i_WrongFuelType.ToString(), i_AppropriateFuelType.ToString()))
        {

        }
    }
}
