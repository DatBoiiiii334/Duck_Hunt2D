using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAI_FSM : MonoBehaviour
{
    //StateMachine related
    public enum State { MoveTowards, Dead };
    public State enumState;

    //GameCharacteur related
    public float DeathTimer;
    public float speed;
    public bool notDead;
    public GameObject[] targets;
    public GameObject BombRadius; //if this charactuer isnt going to use a bombradius, then just add an empty child

    private int myTarget;
    private Vector2 currentTarget;
    private Animator myAnimator;

    private void Start()
    {
        notDead = true;
        myTarget = Random.Range(0, targets.Length);
        myAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        switch (enumState) {
            case State.MoveTowards:
                Fly();
                break;
            case State.Dead:
                BeenKilled();
                break;

            default:
                enumState = State.MoveTowards;
                break;
        }

        //Your children are 1.Empty Child with 3Dcollider and 2.Empty Child with a 2DCollider.
        //The empty child with the 3D collider is there for the shoot script, to let you know its time to die
        //And the empty child with the 2D collider is there as an explosion radius that gets turned on when you enter Dying();
        if (transform.childCount <= 1) {
            enumState = State.Dead;
        }
        else if (notDead) {
            enumState = State.MoveTowards;
        }
        else {
            enumState = State.Dead;
        }
    }

    void Fly()
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

    void BeenKilled()
    {
        notDead = false;
        StartCoroutine(Dying());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomb") {
            enumState = State.Dead;
        }
    }

    IEnumerator Dying()
    {
        myAnimator.SetBool("IsShot", true);
        BombRadius.SetActive(true);
        yield return new WaitForSeconds(DeathTimer);
        BombRadius.SetActive(false);
        myAnimator.SetBool("IsShot", false);
        StopCoroutine(Dying());
        Destroy(gameObject);
    }

}