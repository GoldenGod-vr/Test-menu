using System;
using System.Collections.Generic;
using System.Text;

namespace TEST_MENU.Mods
{
    internal class Ghost_Monke
    {
        public static void Ghostmonke()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
    }
}
