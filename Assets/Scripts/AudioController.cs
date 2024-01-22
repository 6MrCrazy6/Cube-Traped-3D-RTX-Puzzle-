using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioSource music;
    public Slider slider;

    private void Awake()
    {
        if (music != null && !PlayerPrefs.HasKey("Volume"))
        {
            music.volume = 1f;
        }
    }

    void Update()
    {
        if(music != null)
        {
            music.volume = PlayerPrefs.GetFloat("Volume");
        }
    } 
}
