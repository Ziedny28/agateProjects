using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingComponent : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 5.0f;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0.0f, 0.0f, _rotationSpeed);
    }
}
