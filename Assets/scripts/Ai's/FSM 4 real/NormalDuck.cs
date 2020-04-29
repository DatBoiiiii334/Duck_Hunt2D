using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDuck : BaseDuckling, Idamagable
{

    protected void Start()
    {
        currentHealth = 1;
        speed = 2;

        myStateDictionary.Add("fly", new FlyState());
        myStateDictionary.Add("dead", new DeadState());
        currentState = myStateDictionary["fly"];
        if (currentState != null) {
            currentState.OnEnter(this);
        }
    }


    public void GiveDamage(int damage)
    {
        currentHealth -= damage;
    }
}
