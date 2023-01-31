using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interaction : MonoBehaviour
{
    public bool IsInRange;
    public KeyCode interactionKey;
    public UnityEvent interactionEvent;
    
    public void Update()
    {
        if (IsInRange)
        {
            if(Input.GetKeyDown(interactionKey)) interactionEvent.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            IsInRange = true;
            print("Dedans");
        }
    }
    
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            IsInRange = false;
            print("Dehors");
        }
    }
}
