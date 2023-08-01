using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARScreenTween : MonoBehaviour
{
    [SerializeField] GameObject instruction, ARButtons;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveLocal(instruction, new Vector3(0f, 0f, 0f), 2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.moveLocal(ARButtons, new Vector3(0f, 0f, 0f), 2f).setDelay(0.5f).setEase(LeanTweenType.easeInOutCubic);
    }
}
