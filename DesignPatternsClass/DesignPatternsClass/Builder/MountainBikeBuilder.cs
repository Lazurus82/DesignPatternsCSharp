﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsClass;

namespace Builder
{
    public class MountainBikeBuilder : BikeBuilder
    {
        private AbstractMountainBike mountainBikeInProgress;

        public override IBicycle Bicycle
        {
            get { return mountainBikeInProgress; }
        }

        public MountainBikeBuilder(AbstractMountainBike mountainBike)
        {
            this.mountainBikeInProgress = mountainBike;
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("Building Mountainbike handle bars.");
        }

        public override void BuildWideTires()
        {
            Console.WriteLine("Building Mountainbike Street Tires");
        }

    }
}