using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMover : UseAnimation
{
    public GameObject[] targets;
    protected int speed;

    private int myTarget;
    protected Vector2 currentTarget;

    protected void Awake()
    {
        myTarget = Random.Range(0, targets.Length);
    }

    protected void Fly()
    {
        //Check if you are at target position
        if (transform.position.x == targets[myTarget].transform.position.x) {
            if (transform.position.y == targets[myTarget].transform.position.y) {
                //if so then go to new target posiiton
                myTarget = Random.Range(0, targets.Length);
            }
        }
        //move towards your current target if you are not dead
        currentTarget = new Vector2(targets[myTarget].transform.position.x, targets[myTarget].transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);
    }
}
