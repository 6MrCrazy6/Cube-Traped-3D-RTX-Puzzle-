using UnityEngine;
using UnityEngine.UI;

public class ChangeLanguageText1 : MonoBehaviour
{
    public string onuk;
    public string onen;
    public Text texts;

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
