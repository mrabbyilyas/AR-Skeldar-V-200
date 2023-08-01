using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Y : MonoBehaviour
{
    public float rotationSpeed;

    void Update()
    {
        transform.Rotate(0, rotationSpeed * 10 * Time.deltaTime, 0);
    }
}