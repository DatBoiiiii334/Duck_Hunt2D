using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadState : State
{
    private float time = 2f;

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
        yield return new WaitForSeconds(time);
        DuckBody.myAnimator.SetBool("IsShot", false);

        DuckBody.StopCoroutine(PlayDead(DuckBody));
        DuckBody.currentHealth = 1;
        DuckBody.speed = 2;
        DuckBody.ChangeState("fly");
        DuckBody.transform.gameObject.SetActive(false);

    }
}
