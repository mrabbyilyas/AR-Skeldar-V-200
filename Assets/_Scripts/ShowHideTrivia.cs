using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideTrivia : MonoBehaviour
{
    public GameObject triviaPanel;
    public AudioSource audioSource;
    public AudioClip audioClip;

    private void OnMouseUpAsButton() {
        if (triviaPanel.activeInHierarchy == false)
        {
            triviaPanel.SetActive(true);
            LeanTween.scale(triviaPanel, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutElastic);
        }
        else
        {
            triviaPanel.SetActive(false);
        }

        audioSource.clip = audioClip;
        audioSource.Play();
        Debug.Log("Hit");  
    }
}