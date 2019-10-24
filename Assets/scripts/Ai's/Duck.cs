using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour, Idamagable
{
    //StateMachine related
    public enum State { MoveTowards, Dead };
    public State enumState;

    //GameCharacteur related
    public int DuckHp;
    public float DeathTimer;
    public float speed;
    public bool notDead;
    public GameObject[] targets;
    //public GameObject BombRadius; //if this charactuer isnt going to use a bombradius, then just add an empty child

    private int myTarget;
    private Vector2 currentTarget;
    private Animator myAnimator;

    private void Start()
    {
        DuckHp = 1;
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

        if (DuckHp <= 0) {
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

    IEnumerator Dying()
    {
        myAnimator.SetBool("IsShot", true);
        //BombRadius.SetActive(true);
        yield return new WaitForSeconds(DeathTimer);
        //BombRadius.SetActive(false);
        myAnimator.SetBool("IsShot", false);
        StopCoroutine(Dying());
        Destroy(gameObject);
    }

    public void GiveDamage(int damage)
    {
        DuckHp -= damage;
        //Debug.Log("Got Hit");
    }
}
