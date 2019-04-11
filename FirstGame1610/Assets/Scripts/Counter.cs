using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int Value = 3;
    // Start is called before the first frame update
    IEnumerable<WaitForSeconds> Start()
    {
        while (Value > 0)
        {
            yield return new WaitForSeconds(2);
            print(Value);
            Value--;
        }
    }


}
