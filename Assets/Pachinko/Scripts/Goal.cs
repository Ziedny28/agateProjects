using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] private float _score = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"Masuk dengan score {_score}");
    }
}
