using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingState : State
{
    private float time = 2f;
    public GameObject explosionRadius;

    public override void OnEnter(BaseDuckling duckling)
    {
        duckling.StartCoroutine(PlayDead(duckling));
    }

    public override void OnExit(BaseDuckling duckling)
    {

    }

    public override void OnUpdate(BaseDuckling duckling)
    {
        
    }

    IEnumerator PlayDead(BaseDuckling DuckBody)
    {
        DuckBody.myAnimator.SetBool("IsShot", true);
        //explosionRadius.SetActive(true);

        yield return new WaitForSeconds(time);

        DuckBody.myAnimator.SetBool("IsShot", false);
        //explosionRadius.SetActive(false);

        DuckBody.StopCoroutine(PlayDead(DuckBody));

        DuckBody.currentHealth = 3;
        DuckBody.speed = 2;
        DuckBody.ChangeState("fly");
        DuckBody.transform.gameObject.SetActive(false);
    }
}
