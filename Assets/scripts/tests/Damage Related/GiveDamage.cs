using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveDamage : MonoBehaviour
{
    public int myDamage;

    public void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (Input.GetMouseButtonDown(0)) {

            if(hit.collider != null) {
                hit.collider.GetComponent<Idamagable>().GiveDamage(myDamage);
                //Debug.Log("Gave Damage");
            }
        } 
    }
}
