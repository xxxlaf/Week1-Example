using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioClip audioClip;
    public AudioSource audioSource;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void PlayAudio()
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
