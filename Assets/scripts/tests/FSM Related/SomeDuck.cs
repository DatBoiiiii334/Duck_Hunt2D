using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeDuck : MonoBehaviour
{
    public static SomeDuck values;
    public FSMState startState;
    SimpleFSM fsm;

    //public GameObject[] targets;
    //public int myTarget;

    public float PosX;
    public float PosY;

    

    void Start()
    {
        fsm = new SimpleFSM(startState, new MovementState(FSMState.Fly), new DieState(FSMState.Die));
    }

    void Update()
    {

        fsm.OnUpdate();

        //MoveTowardsTarget();

        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log(PosX);
        }
    }


    
}
