using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class Switches : MonoBehaviour
{
    public UnityEvent StartingEvent, PlayingEvent, DyingEvent, EndingEvent;
    public enum States
    {
        Starting,
        Playing,
        Dying,
        Ending
    }
    //make game object and call it GameStates, position 0. Then, add switches to it. 

    [FormerlySerializedAs("CurrentState")] public States currentState;

    private void Update()
    {
        switch (currentState)
        {
            case States.Starting:
                StartingEvent.Invoke();
                break;
            case States.Playing:
                PlayingEvent.Invoke();
                break;
            case States.Ending:
                EndingEvent.Invoke();
                break;
            case States.Dying:
                DyingEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
            
            //back in unity, now we have the events. If you change the current event, it'll play whichever one you select. 
        }
    }
}
