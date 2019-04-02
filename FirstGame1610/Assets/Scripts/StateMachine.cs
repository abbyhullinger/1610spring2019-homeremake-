using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

[CreateAssetMenu]
public class StateMachine : ScriptableObject
{
    public UnityEvent StartingEvent, PlayingEvent, EndingEvent;
  public enum States
  {
      Starting,
      Playing,
      Ending
  }

  [FormerlySerializedAs("CurrentStates")] public States currentStates;
  
  
 
    
    public void OnSwitch()
    {
        switch (currentStates)
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
            default:
                //Work
                break;
        }  
    }
}
//make sure to watch stream again when you go back into unity to do the work there