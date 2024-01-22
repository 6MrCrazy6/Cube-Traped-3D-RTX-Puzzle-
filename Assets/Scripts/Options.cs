using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public void ClearData()
    {
        PlayerPrefs.DeleteKey("Levels");
    }
}
