using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckHealth : MonoBehaviour
{
    //Health related 
    public float DeathTimer;
    public GameObject BombRadius;
    private Animator myAnimator;
    private Duck_Move myMoveScript;

    private void Start()
    {
        myMoveScript = GetComponent<Duck_Move>();
        myAnimator = GetComponent<Animator>();

        myMoveScript.notDead = true;
    }

    public void Update()
    {   //Will always have one child, either the bombradius or filler
        if(transform.childCount <= 1) {
            BeenKilled();
        }
    }

    public void BeenKilled()
    {
        myMoveScript.notDead = false;
        StartCoroutine(Dying());
    }

    IEnumerator Dying()
    {
        myAnimator.SetBool("IsShot",true);
        BombRadius.SetActive(true);
        yield return new WaitForSeconds(DeathTimer);
        BombRadius.SetActive(false);
        myAnimator.SetBool("IsShot", false);
        StopCoroutine(Dying());
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Bomb") {
            BeenKilled();
        }
    }

    public void OnMouseEnter()
    {
        ChangeCursor.myCursor.redReticle.SetActive(true);
    }

    public void OnMouseExit()
    {
        ChangeCursor.myCursor.redReticle.SetActive(false);
    }
}
