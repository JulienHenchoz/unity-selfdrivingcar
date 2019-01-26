using System.Collections;
using System.Collections.Generic;
using Application;
using UnityEngine;

public class StateController : MonoBehaviour
{
    public float velocity = 0;

    public State currentState;
    public State remainState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentState != null) {
            currentState.UpdateState(this);
        }
    }

    public void TransitionToState(State nextState)
    {
        if (nextState != remainState)
        {
            currentState = nextState;
        }
    }
}
