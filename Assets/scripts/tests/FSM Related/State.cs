using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    public SimpleFSM myfsm;
    public FSMState id;

    public State(FSMState myId)
    {
        id = myId;
    }
    public abstract void OnEnter();
    public abstract void OnUpdate();
    public abstract void OnExit();
}
