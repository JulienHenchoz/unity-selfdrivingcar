using System;
using UnityEngine;

namespace Application
{
    [CreateAssetMenu(menuName = "PluggableAI/Actions/Brake")]
    public class BrakeAction: Action 
    {
        public override void Act(StateController stateController)
        {
            MovementController movementController = stateController.GetComponentInParent<MovementController>();

            movementController.Brake();
        }
    }
}
