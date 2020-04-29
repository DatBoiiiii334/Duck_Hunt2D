using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State 
{
    public abstract void OnEnter(BaseDuckling duckling);
    public abstract void OnUpdate(BaseDuckling duckling);
    public abstract void OnExit(BaseDuckling duckling);
}
