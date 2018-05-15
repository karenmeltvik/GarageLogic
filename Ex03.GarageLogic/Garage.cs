using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Garage
    {
        private string m_OwnerName;
        public string OwnerName { get; set; }

        private string m_OwnerPhoneNumber;
        public string OwnerPhoneNumber { get; set; }

        public enum VehicleStatus { InRepair, Repaired, PaidFor } // how to set this enum to InRepair when adding to garage??
        public VehicleStatus m_Status;
    }
}
