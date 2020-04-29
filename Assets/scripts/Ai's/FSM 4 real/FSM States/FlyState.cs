using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyState : State
{
    //private float speed = 2;
    //[SerializeField]

    private Vector2 currentTarget;
    private int myTarget;
    private int mySpeed;

    public override void OnEnter(BaseDuckling duckling)
    {
        myTarget = Random.Range(0, duckling.targets.Count);
        mySpeed = duckling.speed;
    }

    public override void OnExit(BaseDuckling duckling)
    {
        mySpeed = 0;
    }

    public override void OnUpdate(BaseDuckling duckling)
    {
        if (duckling.currentHealth <= 0) {
            duckling.ChangeState("dead");
        }

        //Check if you are at target position
        if (duckling.transform.position.x == duckling.targets[myTarget].transform.position.x) {
            if (duckling.transform.position.y == duckling.targets[myTarget].transform.position.y) {
                //if so then go to new target posiiton
                myTarget = Random.Range(0, duckling.targets.Count);
            }
        }
        //move towards your current target if you are not dead
        currentTarget = new Vector2(duckling.targets[myTarget].transform.position.x, duckling.targets[myTarget].transform.position.y);
        duckling.transform.position = Vector2.MoveTowards(duckling.transform.position, currentTarget, mySpeed * Time.deltaTime);
    }

    //public void GiveDamage(int damage)
    //{
    //    currentHealth -= damage;
    //}

}
