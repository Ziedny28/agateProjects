using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private bool _isRandom = true;
    [SerializeField] private Color _newColor;

    private SpriteRenderer _renderer;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _renderer.color = _isRandom? Random.ColorHSV() : _newColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
