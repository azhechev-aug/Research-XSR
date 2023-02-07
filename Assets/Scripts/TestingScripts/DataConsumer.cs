using SimpleCrossSceneReferences;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataConsumer : MonoBehaviour
{
    //[CrossSceneReference]
    //public List<DataContainer> ConsumptionTargets;
    
    [CrossSceneReference]
    public DataContainer ConsumptionTarget;

    public int Index = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //if (ConsumptionTargets == null || ConsumptionTargets.Count == 0) return;
            //if(ConsumptionTargets.Count <= Index)
            //{
            //    Index = Index % (ConsumptionTargets.Count - 1);
            //}
            //Debug.Log($"target's float : {ConsumptionTargets[Index].TestFloat}");
            //Index++;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (ConsumptionTarget == null) return;
            Debug.Log($"target's float : {ConsumptionTarget.TestFloat}");
            Index++;
        }
    }
}
