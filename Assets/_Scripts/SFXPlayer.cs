using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip start_SFX, Back_SFX, quit_SFX;

    public void StartSFX()
    {
        audioSource.clip = start_SFX;
        audioSource.Play();
    }
    public void BackSFX()
    {
        audioSource.clip = Back_SFX;
        audioSource.Play();
    }

    public void QuitSFX()
    {
        audioSource.clip = quit_SFX;
        audioSource.Play();
    }
}
