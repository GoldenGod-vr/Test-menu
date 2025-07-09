using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace TEST_MENU.Mods
{
    internal class Noclip
    {
        public static void Noclip1()
        {
            bool disableColliders = ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f;
            MeshCollider[] colliders = Resources.FindObjectsOfTypeAll<MeshCollider>();

            foreach (MeshCollider collider in colliders)
            {
                collider.enabled = !disableColliders;
            }
        }
    }
}
