using System;
using UnityEngine;

namespace Application
{
    public abstract class Action : ScriptableObject
    {
        public abstract void Act(StateController stateController);
    }
}
