using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Choselevel : MonoBehaviour
{
    int levelUnlock;
    public Button[] buttons;

    private void Start()
    {
        levelUnlock = PlayerPrefs.GetInt("Levels", 1);

        for(int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for(int i = 0; i < levelUnlock; i++)
        {
            buttons[i].interactable = true;
        }
    }
    
    public void LoadLevels(int LevelIndex)
    {
        SceneManager.LoadScene("Level " + LevelIndex);
    }

    public void TrollLevel1()
    {
        SceneManager.LoadScene("Troll Level 1");
    }
}
