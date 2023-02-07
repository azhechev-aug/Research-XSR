using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataContainer : MonoBehaviour
{
    public DataContainerSO DataSource;

    [HideInInspector]
    public string TestString => DataSource != null ? DataSource.TestString : testString;

    [HideInInspector]
    public int TestInt => DataSource != null ? DataSource.TestInt : testInt;

    [HideInInspector]
    public float TestFloat => DataSource != null ? DataSource.TestFloat : testFloat;

    [HideInInspector]
    public char TestChar => DataSource != null ? DataSource.TestChar : testChar;

    private void OnValidate()
    {
        testString = TestString;
        testInt = TestInt;
        testFloat = TestFloat;
        testChar = TestChar;
    }


    [SerializeField]
    private string testString;

    [SerializeField]
    private int testInt;

    [SerializeField]
    private float testFloat;

    [SerializeField]
    private char testChar;
}
