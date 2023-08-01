using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliAnimation : MonoBehaviour
{
    public Animator HeliAnim;

    public AudioSource source;
    public AudioClip animationButtonSFX;

    public void onClickedAnimStart()
    {
        source.clip = animationButtonSFX;
        source.Play();
        HeliAnim.SetTrigger("StartHeli");
        Debug.Log("Helicopter Animation Start");
    }
}
