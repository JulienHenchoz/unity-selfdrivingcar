using System;
using UnityEngine;

namespace Application
{
    [CreateAssetMenu(menuName = "Stats/CarStats")]
    public class CarStats : ScriptableObject
    {
        public float maxSpeed = 0.5f;
        public float acceleration = 0.05f;
        public float maxRotation = 1f;
        public float brakeForce = 0.04f;
        public float viewDistance = 2f;
        public float safetyDistance = 0.2f;

    }
}
