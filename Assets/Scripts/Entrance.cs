using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

[RequireComponent(typeof(AudioSource))]
public class Entrance : MonoBehaviour
{
    [SerializeField] private UnityEvent _entered;
    [SerializeField] private UnityEvent _exited;

    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerController player))
        {
            int durationOfVolumeDown = 4;
            _entered?.Invoke();
            _audioSource.DOFade(1, durationOfVolumeDown);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        int durationOfVolumeIncrease = 4;
        if (collision.TryGetComponent(out PlayerController player))
        {
            _exited?.Invoke();
            _audioSource.DOFade(0, durationOfVolumeIncrease);
        }
    }
}
