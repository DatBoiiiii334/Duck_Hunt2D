using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseDuckling : MonoBehaviour
{
    public List<GameObject> targets;
    public Animator myAnimator;
    public State currentState;

    public int currentHealth;
    public int speed;

    protected Rigidbody2D myRB;   
    protected Dictionary<string, State> myStateDictionary = new Dictionary<string, State>();

    public void Awake()
    {
        myRB = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    protected virtual void Update()
    {
        if (currentState != null) {
            currentState.OnUpdate(this);
        }
    }

    public void ChangeState(string stateName)
    {
        if (currentState != null) {
            currentState.OnExit(this);
        }
        if (myStateDictionary.ContainsKey(stateName)) {
            currentState = myStateDictionary[stateName];
            currentState.OnEnter(this);
        }
    }
}
