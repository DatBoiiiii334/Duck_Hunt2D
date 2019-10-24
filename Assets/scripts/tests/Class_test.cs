using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class_test : MonoBehaviour, Idamagable
{
    public float Myhealth;

    public void GiveDamage(int damage)
    {
        Myhealth -= damage;
        Debug.Log(Myhealth);
    }
}
