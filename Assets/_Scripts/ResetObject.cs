using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour
{
    Vector3 originalPosition;
    Vector3 originalRotation;
    Vector3 originalScale;

    public AudioSource audioSource;
    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = gameObject.transform.position;
        originalRotation = gameObject.transform.eulerAngles;
        originalScale = gameObject.transform.localScale;
    }

    public void Reset()
    {
        audioSource.clip = audioClip;
        audioSource.Play();

        gameObject.transform.position = originalPosition;
        gameObject.transform.eulerAngles = originalRotation;
        gameObject.transform.localScale = originalScale;
        Debug.Log("Reset");
    }
}