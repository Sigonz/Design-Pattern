﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder.Vehicle_Industry
{
   public  class VehicleDirector
    {
        public void Construct(IVehicleBuilder builder)
        {
            builder.Color();
            builder.Model();
            builder.Engine();
        }
    }
}