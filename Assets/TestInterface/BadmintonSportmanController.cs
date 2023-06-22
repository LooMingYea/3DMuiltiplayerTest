using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.State
{
    public class BadmintonSportmanController : MonoBehaviour
    {
        public float maxSpeed = 3f;
        public float currentSpeed { get; set; }


        private ICharacterState 
            Receive,
            Returned,
            Serve,
            ServeReceiver,
            Running,
            Stop;

        private BadmintonSportmanStateContext _badmintonSportmanStateContext;
        private void Start()
        {
            _badmintonSportmanStateContext =
                new BadmintonSportmanStateContext(this);

            Receive =
                gameObject.AddComponent<ReceiveState>();
            Returned =
                gameObject.AddComponent<ReturnedState>();
            Serve =
                gameObject.AddComponent<ServeState>();
            ServeReceiver=
                 gameObject.AddComponent<ReceiveServeState>();
            Running=
                 gameObject.AddComponent<RunState>();
            Stop=
                gameObject.AddComponent<StopState>();

            _badmintonSportmanStateContext.Transition(Stop);
        }

        public void ToReceiveShuttle()
        {
            _badmintonSportmanStateContext.Transition(Receive);
        }

        public void ReturnedShuttle()
        {
            _badmintonSportmanStateContext.Transition(Returned);
        }

        public void ToServe()
        {
            _badmintonSportmanStateContext.Transition(Serve);
        }

        public void ToReceiveServe()
        {
            _badmintonSportmanStateContext.Transition(ServeReceiver);
        }

        public void StartRunning()
        {
            _badmintonSportmanStateContext.Transition(Running);
        }

        public void StopPlay()
        {
            _badmintonSportmanStateContext.Transition(Stop);
        }

    }
}
