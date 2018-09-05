using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utilities
{
    public static class Tools
    {
        /// <summary>
        /// Maps a value between 0 an 1.
        /// </summary>
        public static float Map01(float value, float oldMin, float oldMax)
        {
            float range = oldMax - oldMin;
            float o = (value - oldMin) / range;
            return o;
        }

        /// <summary>
        /// Maps a value to a new range.
        public static float Map(float value, float oldMin, float oldMax, float newMin, float newMax)
        {
            float norm = Map01(value, oldMin, oldMax);
            float newRange = newMax - newMin;
            float o = (norm * newRange) + newMin;

            return o;
        }
    }
}