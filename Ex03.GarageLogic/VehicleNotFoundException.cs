using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class VehicleNotFoundException : Exception
    {
        public VehicleNotFoundException(string i_licenceNuber)
            : base(string.Format("Vehicle with Licence {0} Not found", i_licenceNuber))
        { }
    }
}
