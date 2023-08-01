using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliTween : MonoBehaviour
{
    [SerializeField] GameObject HelliButtons;

    void Start() {
        LeanTween.scale(HelliButtons, new Vector3(1.0f, 1.0f, 1.0f), 2f).setDelay(0.8f).setEase(LeanTweenType.easeOutElastic);
    }
}
