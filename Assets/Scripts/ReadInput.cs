using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ReadInput : MonoBehaviour
{
    public static string playerName;
    public void ReadStringInput(string playerName)
    {
        name = playerName;
        Debug.Log(name);
    }
}
