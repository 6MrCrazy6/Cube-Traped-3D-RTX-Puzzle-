using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLanguageText : MonoBehaviour
{
    public string onuk;
    public string onen;
    public TextMeshProUGUI texts;

    private int Db;
    
    void Start()
    {
        ChangeText();
    }
    
    void Update()
    {
        ChangeText();
    }

    public void ChangeText()
    {
        Db = PlayerPrefs.GetInt("Dropdown");

        if (Db == 1)
        {
            texts.text = onuk;
        }
        if (Db == 0)
        {
            texts.text = onen;
        }
    }
}
