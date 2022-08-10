using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ReadInput : MonoBehaviour
{
    public string playerName;
    public void ReadStringInput(string playerName)
    {
        SecondaryManager.Instance.pName = playerName;
        Debug.Log(playerName);
    }
}
