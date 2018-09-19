﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
   public class Vintage : AbstractRoadBike
    {
        public Vintage()
          : this(BikeColor.Green)
        {

        }
        public Vintage(BikeColor color)
             : base(color)

        {

        }


    }
}
