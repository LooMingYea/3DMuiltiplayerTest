using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class MultiplayerUI : MonoBehaviour
{
    public NetworkManager manager;

    private void Awake()
    {
        manager = GameObject.Find("NetworkManager").GetComponent<NetworkManager>();
    }
    public void multiplayerMode()
    {
        if (!NetworkClient.active)
        {
            manager.StartClient();
            // This updates networkAddress every frame from the TextField
            manager.networkAddress = "192.168.0.107";
            Debug.Log("NetworkClient.active = false");
        }
        else
        {
            Debug.Log("NetworkClient.active = true");
        }
    }
}