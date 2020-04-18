using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckStats : WaypointMover, IAssign_HP, Idamagable
{
    protected int hp;

    //protected void Start()
    //{
    //    AssignHealthAmount(hp);
    //    AssignSpeedAmount(speed); 
    //}

    protected void Update()
    {
        Fly();
        if (hp <= 0) {
            speed = 0;
            //currentTarget = new Vector2(transform.position.x, transform.position.y);
            StartCoroutine(PlayAnimation());
            hp = 1;
            speed = 3;
        }
    }

    public void AssignHealthAmount(int myHp)
    {
        hp = myHp;
    }

    public void AssignSpeedAmount(int mySpeed)
    {
        speed = mySpeed;
    }

    public void GiveDamage(int damage)
    {
        hp -= damage;
    }
}
