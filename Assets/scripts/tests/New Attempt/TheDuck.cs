using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDuck : DuckStats
{

    protected void Start()
    {
        myAnimator = GetComponent<Animator>();
        AssignHealthAmount(1);
        AssignSpeedAmount(3);

        AssignHealthAmount(hp);
        AssignSpeedAmount(speed);
    }
}
