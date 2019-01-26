using System;
using UnityEngine;

namespace Application
{
    [CreateAssetMenu(menuName = "PluggableAI/Actions/Accelerate")]
    public class AccelerateAction: Action 
    {
        public override void Act(StateController stateController)
        {
            MovementController movementController = stateController.GetComponentInParent<MovementController>();

            movementController.Accelerate();
        }
    }
}
