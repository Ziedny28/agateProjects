using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform _startPos, _endPos;
    [SerializeField] private Transform _playerTransform; // the object of player thatll spawned the ball
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _ballPrefab;

    private Vector2 _targetPos;
    // Start is called before the first frame update
    void Start()
    {
        _playerTransform.position = _startPos.position;
        _targetPos = _endPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        //if player cloose with startPos 
        if(Vector2.Distance(_playerTransform.position, _startPos.position) < 0.1f) 
        {
            _targetPos = _endPos.position;//set target to endPos
        }

        //if player cloose with endPos
        if (Vector2.Distance(_playerTransform.position, _endPos.position) < 0.1f)
        {
            _targetPos = _startPos.position;//set target to startPos
        }

        _playerTransform.position = Vector2.MoveTowards(_playerTransform.position, _targetPos, _speed * Time.deltaTime); //move to target

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(_ballPrefab, _playerTransform.position, Quaternion.identity);
        }
    }
}
