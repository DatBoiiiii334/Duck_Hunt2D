using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck_Move : MonoBehaviour
{
    public float speed;
    public GameObject[] targets;


    private Vector2 currentTarget;
    public bool notDead;
    private int myTarget;
   

    private void Start()
    {
        notDead = true;
        myTarget = Random.Range(0, targets.Length);
    }

    void Update()
    {
        //Check if you are there
        if (transform.position.x == targets[myTarget].transform.position.x) {
            if (transform.position.y == targets[myTarget].transform.position.y) {
                //if so then go to new location
                myTarget = Random.Range(0, targets.Length);
            }
        }

        if (notDead) {
            MoveTowards();
        }
    }
    

    public void MoveTowards()
    {//move towards your current target if you are not dead
        currentTarget = new Vector2(targets[myTarget].transform.position.x, targets[myTarget].transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);
    }
}
