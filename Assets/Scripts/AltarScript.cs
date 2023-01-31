using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarScript : MonoBehaviour
{
    [SerializeField] public bool nonInteractable;
    [SerializeField] public SpriteRenderer centralRune;

    private bool _runeState = false;

    private void Awake()
    {
        if (nonInteractable) _runeState = true;

        centralRune.color = _runeState ? new Color(1, 1 , 1, 1) : new Color(0, 0 , 0, 0.1f);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(nonInteractable) return;

        _runeState = !_runeState;
        if (_runeState)
        {
            centralRune.color = new Color(1, 1 , 1, 1);
        }
        else
        {
            centralRune.color = new Color(0, 0 , 0, 0.1f);
        }
        
    }
}
