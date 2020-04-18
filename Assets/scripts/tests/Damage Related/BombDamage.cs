using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDamage : MonoBehaviour
{
    //private int myBombDamage;

    private void Start()
    {
        //PointManager.instance.Damage = this.myBombDamage;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //collision.collider.GetComponent<Idamagable>().GiveDamage(myBombDamage);
    }
}
