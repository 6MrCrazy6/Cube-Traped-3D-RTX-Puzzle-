using TMPro;
using UnityEngine;

public class ChangeLanguage : MonoBehaviour
{
    public TMP_Dropdown Db;


    void Start()
    {
        if (!PlayerPrefs.HasKey("Dropdown")) Db.value = 0;
        else Db.value = PlayerPrefs.GetInt("Dropdown");
        Check();
    }

    public void InputMenu()
    {
        if(Db.value == 0)
        {
            Localisation.Inst.langs = "en";
            PlayerPrefs.SetInt("Dropdown", Db.value);
            PlayerPrefs.Save();
        }
        if(Db.value == 1)
        {
            Localisation.Inst.langs = "uk";
            PlayerPrefs.SetInt("Dropdown", Db.value);
            PlayerPrefs.Save();
        }
    }

    public void Check()
    {
        if(Localisation.Inst.langs == "uk")
        {

            Db.value = PlayerPrefs.GetInt("Dropdown");
        }

        if(Localisation.Inst.langs == "en")
        {
            Db.value = PlayerPrefs.GetInt("Dropdown");
        }
    }
}
