using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new DataContainer", menuName = "TEST/XSRDataContainer", order = 0)]
public class DataContainerSO : ScriptableObject
{
    public string TestString;

    public int TestInt;

    public float TestFloat;

    public char TestChar;
}
