using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonPanelOpener : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    public GameObject Panel;
    public GameObject Medal;
    public void OnSelect(BaseEventData eventData)
    {
        Panel.SetActive(true);
        Medal.SetActive(true);
    }

    public void OnDeselect(BaseEventData eventData)
    {
        Panel.SetActive(false);
        Medal.SetActive(false);
    }
}
