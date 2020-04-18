using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FSMState { Fly, Die }
public class SimpleFSM 
{
    public State currentState;

    public Vector2 xPosition;
    public Vector2 yPosition;

    private Dictionary<FSMState, State> stateDictionary = new Dictionary<FSMState, State>();
    public SimpleFSM(FSMState startState, params State[] states)
    {
        foreach (State state in states) {
            state.myfsm = this;
            stateDictionary.Add(state.id, state);
        }
        SwitchState(startState);
    }

    public void OnUpdate()
    {
        currentState?.OnUpdate();
    }

    public void SwitchState(FSMState newState)
    {
        currentState?.OnExit();
        if (stateDictionary.ContainsKey(newState)) {
            currentState = stateDictionary[newState];
            currentState?.OnEnter();
        }
    }
}
