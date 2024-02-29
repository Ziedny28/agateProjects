using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalingComponent : MonoBehaviour
{
    [SerializeField] private float _minScale= 0.3f;
    [SerializeField] private float _maxScale= 1f;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localScale = new Vector4(Mathf.PingPong(Time.time, (_maxScale - _minScale)) + _minScale, transform.localScale.x, transform.localScale.y, transform.localScale.z); //always change value from min to max, max to min and so on
    }
}
