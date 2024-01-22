using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{


    public void BackToMenu()
    {
        AdMobInterstitial.Instance.ShowInterstitialAd();
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void RepeatLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }
}
