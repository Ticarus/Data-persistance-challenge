using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    public static string name;

    public void ReadStringInput(string pName)
    {
        name = pName;
        Debug.Log(name);
    }
}
