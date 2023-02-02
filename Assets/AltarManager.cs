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

    private int count;
    
    public void ChangeThisAltarState(AltarScript currentAltar)
    {

        if(currentAltar.nonInteractable) return;
                
        if (altars.IndexOf(currentAltar) == count)
        {
            currentAltar.nonInteractable = true;
            count++;
            print("plaque " + (altars.IndexOf(currentAltar)+1) + " touché");
        }
        else
        {
            currentAltar.ChangeState(false);
            print("heeep mauvaise plaque, c'est la plaque " + (altars.IndexOf(currentAltar)+1) + " ça");
        }
        
        CheckAllAltarsStates();
    }

    private void CheckAllAltarsStates()
    {
        if(count == altars.Count) afterActionEvent.Invoke();
    }
    
    
}
