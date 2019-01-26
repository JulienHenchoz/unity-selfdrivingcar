using System;
using UnityEngine;

namespace Application
{
    [CreateAssetMenu(menuName = "PluggableAI/Decisions/Brake")]
    public class BrakeDecision : Decision
    {
        public override bool Decide(StateController stateController)
        {
            bool shouldBrake = false;

            Transform transform = stateController.transform;
            MovementController movementController = stateController.GetComponent<MovementController>();
            Collider2D collider = stateController.GetComponent<Collider2D>();
            Rigidbody2D carRigidBody = stateController.GetComponent<Rigidbody2D>();

            Vector2 forward = transform.TransformDirection(Vector2.up) * movementController.stats.viewDistance;
            Vector2 rayOrigin = new Vector2(transform.position.x + (collider.bounds.size.x / 2), transform.position.y);

            RaycastHit2D forwardRay = Physics2D.Raycast(rayOrigin, forward, movementController.stats.viewDistance);
            Debug.DrawRay(rayOrigin, forward, Color.green);

            if (forwardRay.collider != null && forwardRay.collider.CompareTag("BlockingTile"))
            {
                Vector2 velocity = stateController.GetComponent<Rigidbody2D>().velocity;

                float projectedStoppingDistance = Mathf.Pow(velocity.magnitude, 2) / 2 * 9.81f * carRigidBody.drag ;

                Debug.Log("Projected : " + projectedStoppingDistance);
                Debug.Log("Distance to impact : " + forwardRay.distance);

                if (projectedStoppingDistance < forwardRay.distance - movementController.stats.safetyDistance)
                {
                    shouldBrake = true;
                }
            }

            return shouldBrake;
        }
    }
}
