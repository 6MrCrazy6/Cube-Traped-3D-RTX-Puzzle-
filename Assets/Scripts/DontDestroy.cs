using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    private static bool isCreated = false;
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");

        if (!isCreated)
        {
            DontDestroyOnLoad(this.gameObject);
            isCreated = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }
}
