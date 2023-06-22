using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chapter.State
{
    public class Client : MonoBehaviour
    {
        private BadmintonSportmanController badmintonSportmanController;

        public GameObject A;
        public GameObject B;

        void Start()
        {
            //badmintonSportmanController = A.GetComponent<BadmintonSportmanController>();
        }

        void OnGUI()
        {
            if (GUILayout.Button("ToReceiveShuttle"))
                A.GetComponent<BadmintonSportmanController>().ToReceiveShuttle();

            if (GUILayout.Button("ReturnedShuttle"))
                A.GetComponent<BadmintonSportmanController>().ReturnedShuttle();

            if (GUILayout.Button("ToServe"))
                A.GetComponent<BadmintonSportmanController>().ToServe();

            if (GUILayout.Button("ToReceiveServe"))
                A.GetComponent<BadmintonSportmanController>().ToReceiveServe();

            if (GUILayout.Button("StartRunning"))
                A.GetComponent<BadmintonSportmanController>().StartRunning();

            if (GUILayout.Button("StopPlay"))
                A.GetComponent<BadmintonSportmanController>().StopPlay();
        }
    }
}