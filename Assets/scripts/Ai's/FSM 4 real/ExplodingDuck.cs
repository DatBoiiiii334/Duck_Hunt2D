using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingDuck : BaseDuckling, Idamagable
{

    protected void Start()
    {
        currentHealth = 3;
        speed = 3;

        myStateDictionary.Add("fly", new FlyState());
        myStateDictionary.Add("dead", new ExplodingState());
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
