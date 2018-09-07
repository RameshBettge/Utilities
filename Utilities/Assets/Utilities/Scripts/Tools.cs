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

        /// <summary>
        /// Used for the IEnumerator LerpRoutine
        /// </summary>
        /// <param name="percentage">
        /// How far the LerpRoutine has progressed from 0 to 1
        /// </param>
        public delegate void LPDelegate(float percentage);

        /// <summary>
        /// Takes a Delegate (of Type LPDelegate) and executes it once per frame until a timer reaches the given 'learpTime'.
        /// </summary>
        /// <param name="del">
        /// The delegate which is called once per frame
        /// </param>
        /// <param name="lerpTime">
        /// How long the procedure takes
        /// </param>
        /// <param name="wait">
        /// A cached WaitForEndOfFrame to avoid garbage
        /// </param>
        /// <param name="startPercentage">
        /// The timer starts at lerpTime * startPercentage
        /// </param>
        public static IEnumerator LerpRoutine(LPDelegate del, float lerpTime, WaitForEndOfFrame wait, float startPercentage = 0f)
        {
            float timer = lerpTime * startPercentage;
            float percentage = startPercentage;

            while (percentage < 1f)
            {
                percentage = timer / lerpTime;

                del(percentage);

                timer += Time.deltaTime;
                yield return wait;
            }
            del(1f);
        }
    }
}