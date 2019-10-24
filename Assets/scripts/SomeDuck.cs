using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeDuck : MonoBehaviour
{
    public FSMState startState;
    FSM fsm;
    // Start is called before the first frame update
    void Start()
    {
        fsm = new FSM(startState, 
            new IdleState(FSMState.Idle), 
            new AttackState(FSMState.Attack)
            );
    }

    // Update is called once per frame
    void Update()
    {
        fsm.OnUpdate();
    }
}
