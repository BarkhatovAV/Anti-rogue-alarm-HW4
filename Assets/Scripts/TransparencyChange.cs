using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class TransparencyChange: MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Color _transparentСolor;

    private float _currentTime;
    private float normalizeCurrentTime;
    private SpriteRenderer renderer;
    private Color _startColor;

    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        _startColor = renderer.color;
    }

    public void HidePlayer()
    {
        _currentTime = 0;
        StartCoroutine(hide());
    }

    public void FindPlayer()
    {
        _currentTime = 0;
        StartCoroutine(find());
    }

    private IEnumerator hide()
    {
        while (_currentTime <= _duration)
        {
            _currentTime += Time.deltaTime;
            normalizeCurrentTime = _currentTime / _duration;
            renderer.color = Color.Lerp(_startColor, _transparentСolor, normalizeCurrentTime);

            yield return null;
        }
    }

    private IEnumerator find()
    {
        while (_currentTime <= _duration)
        {
            _currentTime += Time.deltaTime;
            normalizeCurrentTime = _currentTime / _duration;
            renderer.color = Color.Lerp(_transparentСolor, _startColor, normalizeCurrentTime);

            yield return null;
        }
    }
}
