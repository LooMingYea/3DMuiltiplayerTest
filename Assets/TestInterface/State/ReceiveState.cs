using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chapter.State
{
    public class ReceiveState : MonoBehaviour,ICharacterState
    {
        private BadmintonSportmanController _badmintonSportmanController;
        public void Handle(BadmintonSportmanController controller)
        {
            if (!_badmintonSportmanController)
                _badmintonSportmanController = controller;

            Debug.Log("ReceiveState " + gameObject.name);
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
