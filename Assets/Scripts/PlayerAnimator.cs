using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(PlayerMover))]
public class PlayerAnimator : MonoBehaviour
{
    private PlayerMover _player;
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _player = GetComponent<PlayerMover>();
    }

    void Update()
    {
        if (_player.IsWalk)
        {
            _animator.SetBool("Walk", true);
        }
        else
        {
            _animator.SetBool("Walk", false);
        }
    }
}
