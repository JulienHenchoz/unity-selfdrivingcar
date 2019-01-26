using UnityEngine;
using System.Collections;
using Application;
using System;

public class MovementController : MonoBehaviour
{
    private float stopThreshold = 0.1f;

    public CarStats stats;

    public Vector2 velocity;

    private new Rigidbody2D rigidbody;

    // Use this for initialization
    void Start()
    {
        velocity = Vector3.zero;
        rigidbody = transform.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Update()
    {

    }


    public void Turn(float deg)
    {
        deg = Mathf.Clamp(deg, -stats.maxRotation, stats.maxRotation);
    }

    public void Accelerate()
    {
        if (rigidbody.velocity.magnitude < stats.maxSpeed)
        {
            rigidbody.AddForce(stats.acceleration * new Vector2(transform.up.x, transform.up.y));
        }
    }

    public void Brake()
    {
        if (rigidbody.velocity.magnitude > 0)
        {
            rigidbody.AddForce(stats.brakeForce * new Vector2(-transform.up.x, -transform.up.y));
        }

        if (rigidbody.velocity.magnitude < stopThreshold)
        {
            rigidbody.velocity = Vector2.zero;
        }
    }
}
