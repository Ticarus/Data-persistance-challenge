using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryManager : MonoBehaviour
{
    public static SecondaryManager Instance;

    public string pName;

    public int highScore;
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
