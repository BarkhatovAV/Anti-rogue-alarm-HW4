using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Alarm : MonoBehaviour
{
    [SerializeField] private float _duration;
    private float _currentVolume;
    private float _currentTime;

    private float normalizeCurrentTime;
    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void Active()
    {
        _currentTime = 0;
        StartCoroutine(active());
    }

    public void Deactive()
    {
        _currentTime = 0;
        StartCoroutine(deactive());
    }

    private IEnumerator active()
    {

        while (_currentTime <= _duration)
        {
            _currentTime += Time.deltaTime;
            normalizeCurrentTime = _currentTime / _duration;
            _audioSource.volume = normalizeCurrentTime;

            yield return null;
        }
    }

    private IEnumerator deactive()
    {
        while (_currentTime <= _duration)
        {
            _currentTime += Time.deltaTime;
            normalizeCurrentTime = _currentTime / _duration;
            _audioSource.volume = 1 - normalizeCurrentTime;

            yield return null;
        }
    }
}
