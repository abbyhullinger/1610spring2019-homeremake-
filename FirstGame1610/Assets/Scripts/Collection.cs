using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Collection : ScriptableObject
{
    public List<FloatData> CollectionList;
    
    
    public void Collect(FloatData obj)
    {
        CollectionList.Add(obj);
    }

    public void CollectionInfo()
    {
        foreach (var obj in CollectionList)
        {
           Debug.Log(obj); 
        }
    }

}
