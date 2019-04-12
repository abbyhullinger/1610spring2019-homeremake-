using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{
    public int Value = 3, MinValue = 0;
    public float WaitTime = 1;

    private UnityEvent OnCountEvent, OnEndEvent;
    
    public IEnumerable RunCounter()
    {
        var waitObject = new WaitForSeconds(WaitTime);
        while (Value > MinValue)
        {
            yield return waitObject;
            OnCountEvent.Invoke();
            Value--;
        }

        yield return waitObject;
        OnEndEvent.Invoke();
    }


}
