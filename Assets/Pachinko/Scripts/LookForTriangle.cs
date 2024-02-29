using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookForTriangle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject triangle = GameObject.FindGameObjectWithTag("Triangle");
        Debug.Log(triangle.name);

        triangle.AddComponent<Rigidbody2D>();
    }
}
