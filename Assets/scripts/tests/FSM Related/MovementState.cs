using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementState : State
{
    public MovementState(FSMState id) : base(id) { };

    public override void OnEnter()
    {
        Debug.Log("Entering Idle State");

        
    }

    public override void OnExit()
    {
        Debug.Log("Exiting Idle State");

    }

    public override void OnUpdate()
    {
    }

    
}
