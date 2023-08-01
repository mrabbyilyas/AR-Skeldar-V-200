using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiStartScreenTween : MonoBehaviour
{
    [SerializeField] GameObject Title, Helicopter, buttons, profile;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(Title, new Vector3(0.8f, 0.8f, 0.8f), 2f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveLocal(Title, new Vector3(0f, 242f, 2f), .7f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(Title, new Vector3(0.55f, 0.55f, 0.55f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);

        LeanTween.moveLocal(Helicopter, new Vector3(0f, 14f, -483f), 1f).setDelay(2.8f).setEase(LeanTweenType.easeInOutCubic);

        LeanTween.moveLocal(buttons, new Vector3(0f, 0f, 0f), 2f).setDelay(3.7f).setEase(LeanTweenType.easeOutElastic);

        LeanTween.moveLocal(profile, new Vector3(0f, 0f, 0f), 2f).setDelay(4f).setEase(LeanTweenType.easeInOutCubic);
    }

    
}
