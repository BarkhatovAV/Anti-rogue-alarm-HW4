using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private bool _isWalk;

    public bool IsWalk => _isWalk;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
            _isWalk = true;
        }
        else
        {
            _isWalk = false;
        }
    }
}
