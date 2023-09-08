using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float rotationSpeed = 10.0f;

    private void Update()
    {
        transform.Rotate(Vector3.one * rotationSpeed * Time.deltaTime);
    }
}
