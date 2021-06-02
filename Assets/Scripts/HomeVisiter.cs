using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;


[RequireComponent(typeof(SpriteRenderer))]
public class HomeVisiter : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    public void HidePlayer()
    {
        float timeOfAppearancePlayer = 1f;
        _spriteRenderer.DOFade(0, timeOfAppearancePlayer);
    }

    public void FindPlayer()
    {
        float timeOfDisappearancePlayer = 1f;
        _spriteRenderer.DOFade(1, timeOfDisappearancePlayer);
    }
}
