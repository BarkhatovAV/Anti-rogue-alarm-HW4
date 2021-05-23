﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] SpriteRenderer _renderer;
    [SerializeField] Color _reachedColor;
    [SerializeField] private UnityEvent _visited;

    private Animator _animator;
    private Color _color;
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime,0,0);
            _animator.SetBool("Walk",true);
        }
        else
        {
            _animator.SetBool("Walk", false);
        }
    }

    public void HidePlayer()
    {
        _color.a = 0;
        _color.r = 0;
        _color.g = 0;
        _color.b = 0;
        _spriteRenderer.DOFade(0, 0.5f);
    }

    public void FindPlayer()
    {
        _spriteRenderer.DOFade(1, 0.5f);
    }
}