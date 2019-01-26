using System;
using UnityEngine;

namespace Application
{
    public abstract class Decision : ScriptableObject
    {
        public abstract bool Decide(StateController stateController);
    }
}
