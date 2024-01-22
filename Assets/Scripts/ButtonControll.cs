using UnityEngine;
using UnityEngine.Events;

public class ButtonControll : MonoBehaviour
{
    public UnityEvent OnButtonDown;
    public UnityEvent OnButtonUp;

    public AudioSource audios;
    public AudioClip soundClick;

    private Vector3 originalScale;
    private bool isPressed = false;


    private void Start()
    {
        originalScale = transform.localScale;
        audios = GetComponent<AudioSource>();
        audios.clip = soundClick;
    }

    private void OnMouseDown()
    {
        isPressed = true;

        if (OnButtonDown != null)
        {
            OnButtonDown.Invoke();
            
        }

        if(soundClick != null)
        {
            audios.PlayOneShot(soundClick);
        }

        transform.localScale = originalScale * 0.9f;
    }

    private void OnMouseUp()
    {
        if (isPressed)
        {
            isPressed = false;

            if (OnButtonUp != null)
            {
                OnButtonUp.Invoke();
            }

            transform.localScale = originalScale;
        }
    }
}
