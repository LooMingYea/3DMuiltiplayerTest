using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using Cinemachine;
using UnityEngine.InputSystem;
namespace StarterAssets
{
    public class enableComponent : NetworkBehaviour
    {
        public Transform target;
        void Start()
        {
            if (isLocalPlayer)
            {
                CharacterController cc = GetComponent<CharacterController>();
                cc.enabled= true;

                ThirdPersonController tpc = GetComponent<ThirdPersonController>();
                tpc.enabled = true;

                PlayerInput pi = GetComponent<PlayerInput>();
                pi.enabled = true;

                GameObject pfc = GameObject.Find("PlayerFollowCamera");

                CinemachineVirtualCamera cvc = pfc.GetComponent<CinemachineVirtualCamera>();
                cvc.Follow = target;
            }
        }
    }
}
