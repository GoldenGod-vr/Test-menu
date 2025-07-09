using System;
using System.Collections.Generic;
using System.Text;

namespace TEST_MENU.Mods
{
    internal class ResetArms
    {
        public static void Resetarms()
        {
            GorillaLocomotion.GTPlayer.Instance.transform.localScale = new UnityEngine.Vector3(1.0f, 1.0f, 1.0f);
        }
    }
}
