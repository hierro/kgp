﻿using Microsoft.Kinect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGP
{
    /// <summary>
    /// Extension methods for Joints
    /// </summary>
    public static class JointExtensions
    {
        /// <summary>
        /// Checks if a joint tracking state is at least inferred
        /// </summary>
        /// <param name="joint">Joint to check</param>
        /// <returns>true if joint is inferred or tracked, false otherwise</returns>
        public static bool IsAtLeastInferred(this Joint joint)
        {
            return joint.TrackingState != TrackingState.NotTracked;
        }
    }
}
