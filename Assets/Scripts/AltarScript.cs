using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AltarScript : MonoBehaviour
{
    [SerializeField] public bool nonInteractable;
    [SerializeField] public SpriteRenderer centralRune;
    [SerializeField] public UnityEvent interactionEvent;

    public bool _runeState = false;

    private void Awake()
    {
        if (nonInteractable) _runeState = true;

        centralRune.color = _runeState ? new Color(1, 1 , 1, 1) : new Color(0, 0 , 0, 0.1f);
    }

    public void ChangeState(bool state)
    {
        _runeState = state;
        if (state)
        {
            centralRune.color = new Color(1, 1 , 1, 1);
        }
        else
        {
            centralRune.color = new Color(0, 0 , 0, 0.1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(nonInteractable) return;
        
        _runeState = !_runeState;
        ChangeState(_runeState);
        interactionEvent.Invoke();
    }
}
