using System;
using UnityEngine;

namespace Application
{
    [CreateAssetMenu(menuName = "PluggableAI/Decisions/Accelerate")]
    public class AccelerateDecision : Decision
    {
        public override bool Decide(StateController stateController)
        {
            return true;
        }
    }
}
