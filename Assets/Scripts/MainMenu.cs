using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    private int currentlevel;

    public Material gameSkybox;
    public float ambientIntensity = 1.5f;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("Levels")) currentlevel = 1;
        else currentlevel = PlayerPrefs.GetInt("Levels");
        PlayerPrefs.SetString("GameSkybox", gameSkybox.name);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level " + currentlevel, LoadSceneMode.Single);
        Debug.Log("Scene loading");
    }

    public void ExitGame()
    {
        Debug.Log("Game Close");
        Application.Quit();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

}
