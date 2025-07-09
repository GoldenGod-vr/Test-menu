using System;
using System.Collections.Generic;
using System.Text;

namespace StupidTemplate.Mods
{
    internal class SpeedBoost
    {
        public static void SpeedBoost1()
        {
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 2.9f;
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 8.5f;
        }
    }
}
