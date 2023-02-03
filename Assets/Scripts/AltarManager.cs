using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AltarManager : MonoBehaviour
{
    [SerializeField] private List<AltarScript> altars;
    [SerializeField] private List<AltarScript> currentActivatedAltars;

    [SerializeField] private UnityEvent afterActionEvent;

    private int _count;
    
    public void ChangeThisAltarState(AltarScript currentAltar)
    {

        if(currentAltar.nonInteractable) return;
                
        if (altars.IndexOf(currentAltar) == _count)
        {
            currentAltar.nonInteractable = true;
            _count++;
        }
        else
        {
            currentAltar.ChangeState(false);
        }
        
        CheckAllAltarsStates();
    }

    private void CheckAllAltarsStates()
    {
        if(_count == altars.Count) afterActionEvent.Invoke();
    }
    
    
}
