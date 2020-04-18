using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseAnimation : MonoBehaviour
{
    public float animDuration;
    public string animBoolName;

    protected Animator myAnimator;

    private void Start()
    {
        
    
        if(myAnimator == null) {
            Debug.LogError("Animator is missing!");
        }
    }

    protected IEnumerator PlayAnimation()
    {
        myAnimator.SetBool(animBoolName, true);
        yield return new WaitForSeconds(animDuration);
        myAnimator.SetBool(animBoolName, false);
        StopCoroutine(PlayAnimation());
        gameObject.SetActive(false);
    }
}
