﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex03
{
    public class ElectricBase : EnergySystem
    {
        public ElectricBase()
        {

        }

        public void Recharge(float i_toAdd)
        {
            RefillEnergy(i_toAdd);
        }
    }
}
