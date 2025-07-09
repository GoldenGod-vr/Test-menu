using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TEST_MENU.Mods
{
    internal class CarMonke
    {
        public static void Carmonke()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += (GorillaLocomotion.GTPlayer.Instance.headCollider.transform.forward * Time.deltaTime) * 15f;
            }
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position -= (GorillaLocomotion.GTPlayer.Instance.headCollider.transform.forward * Time.deltaTime) * 20f;
            }
        }
    }
}
