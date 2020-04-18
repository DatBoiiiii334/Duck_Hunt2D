using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieState : State
{
    public DieState(FSMState id) : base(id) { }

    public override void OnEnter()
    {
        Debug.Log("Entering Die State");
    }

    public override void OnExit()
    {
        Debug.Log("Exiting Die State");

    }

    public override void OnUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            myfsm.SwitchState(FSMState.Fly);
        }
    }
}
