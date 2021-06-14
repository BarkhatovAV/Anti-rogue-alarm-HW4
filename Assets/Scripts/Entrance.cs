using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Entrance : MonoBehaviour
{
    [SerializeField] private UnityEvent _entered;
    [SerializeField] private UnityEvent _exited;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerMover player))
        {
            _entered?.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerMover player))
        {
            _exited?.Invoke();
        }
    }
}
