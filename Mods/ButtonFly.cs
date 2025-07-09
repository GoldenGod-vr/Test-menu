using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace StupidTemplate.Mods
{
    internal class ButtonFly
    {
        public static void Buttonfly()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += (GorillaLocomotion.GTPlayer.Instance.headCollider.transform.forward * Time.deltaTime) * 15f;
                GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
            
        }
    }
}
