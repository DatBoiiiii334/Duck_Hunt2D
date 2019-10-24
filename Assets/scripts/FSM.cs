using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//public enum FSMState { Idle, Attack }
public class FSM
{
//    public State currentState;
//    private Dictionary<FSMState, State> stateDictionary = new Dictionary<FSMState, State>();
//    public FSM(FSMState startState, params State[] states)
//    {
//        foreach (State state in states) {
//            state.fsm = this;
//            stateDictionary.Add(state.id, state);
//        }
//        SwitchState(startState);
//    }

//    public void OnUpdate()
//    {
//        currentState?.OnUpdate();
//    }

//    public void SwitchState(FSMState newState)
//    {
//        currentState?.OnExit();
//        if (stateDictionary.ContainsKey(newState)) {
//            currentState = stateDictionary[newState];
//            currentState?.OnEnter();
//        }
//    }
//}

//public abstract class State
//{
//    public FSM fsm;
//    public FSMState id;

//    public State(FSMState myId)
//    {
//        id = myId;
//    }
//    public abstract void OnEnter();
//    public abstract void OnUpdate();
//    public abstract void OnExit();
//}


//public class IdleState : State
//{
//    public IdleState(FSMState id) : base(id) { }

//    public override void OnEnter()
//    {
//        Debug.Log("Entering Idle State");
//    }

//    public override void OnExit()
//    {
//        Debug.Log("Exiting Idle State");

//    }

//    public override void OnUpdate()
//    {
//        if (Input.GetKeyDown(KeyCode.Space)) {
//            fsm.SwitchState(FSMState.Attack);
//        }
//    }
//}

//public class AttackState : State
//{
//    public AttackState(FSMState id) : base(id) { }

//    public override void OnEnter()
//    {
//        Debug.Log("Entering Attack State");
//    }

//    public override void OnExit()
//    {
//        Debug.Log("Exiting Attack State");

//    }

//    public override void OnUpdate()
//    {
//        if (Input.GetKeyDown(KeyCode.F)) {
//            fsm.SwitchState(FSMState.Idle);
//        }
//    }
}

/*
 * interface (IDamagable)
 * Inheritance
 * intermediate scriptig
 * class in Csharp (constructor, this, abstract, virtual)
 * FSM
 * (events/ delegates)
 * (datastructuren)
 * Object pool
 * */
