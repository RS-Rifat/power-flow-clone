using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotation : MonoBehaviour
{
    public float rotationSpeed = 10.0f;

    void Update()
    {
        // Rotate the object around the y-axis by a specified amount
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime * 50);
    }
}
