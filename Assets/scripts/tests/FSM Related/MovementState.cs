using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementState : State
{
    public MovementState(FSMState id) : base(id) { }

    public int speed = 3;
    public int myTarget;

    public SomeDuck myDuck;

    private Vector2 currentTarget;
    public GameObject[] targets;

    public override void OnEnter()
    {
        Debug.Log("Entering Fly State");
        myDuck.GetComponent<SomeDuck>();
        //SomeDuck(50f, 50f);
    }

    public override void OnExit()
    {
        Debug.Log("Exiting Fly State");

    }

    public override void OnUpdate()
    {

        if (Input.GetKeyDown(KeyCode.S)) {
            Debug.Log("Mytarget is ");
            Debug.Log(myTarget);
        }

        myTarget = Random.Range(0, 7);

        //myPosX = SomeDuck.falues.PosX;
        //myPosY = SomeDuck.falues.PosY;
        

        if (Input.GetKeyDown(KeyCode.D)) {
            myfsm.SwitchState(FSMState.Die);
            Debug.Log("Entering Die state");
        }

        

        //MoveTowardsTarget(50f, 50f, 50f, 50f);
    }

    public void MoveTowardsTarget()
    {
        Debug.Log("Doing it");
        //Check if you are at target position
        if (myDuck.transform.position.x == targets[myTarget].transform.position.x) {
            if (myDuck.transform.position.y == targets[myTarget].transform.position.y) {
                //if so then go to new target posiiton
                SwitchTarget();
            }
        }
        //move towards your current target if you are not dead
        currentTarget = new Vector2(targets[myTarget].transform.position.x, targets[myTarget].transform.position.y);
        SomeDuck.values.transform.position = Vector2.MoveTowards(myDuck.transform.position, currentTarget, speed * Time.deltaTime);
    }

    public void SwitchTarget()
    {
        myTarget = Random.Range(0, targets.Length);
    }

}
