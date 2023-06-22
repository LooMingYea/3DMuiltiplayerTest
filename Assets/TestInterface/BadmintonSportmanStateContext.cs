using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.State
{
    public class BadmintonSportmanStateContext
    {
        public ICharacterState CurrentState { get; set; }

        private readonly BadmintonSportmanController _badmintonSportmanController;

        //constructor
        public BadmintonSportmanStateContext (BadmintonSportmanController badmintonSportmanController)
        {
            _badmintonSportmanController = badmintonSportmanController;
        }
        public void Transition()
        {
            CurrentState.Handle(_badmintonSportmanController);
        }

        public void Transition(ICharacterState state)
        {
            CurrentState = state;
            CurrentState.Handle(_badmintonSportmanController);
        }
    }
}
