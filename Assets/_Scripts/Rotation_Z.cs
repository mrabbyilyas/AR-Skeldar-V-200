using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Z : MonoBehaviour
{
    public float rotationSpeed;

    void Update()
    {
        transform.Rotate(0, 0,rotationSpeed * 10 * Time.deltaTime);
    }
}