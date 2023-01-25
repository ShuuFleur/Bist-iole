using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMousePanelOpener : MonoBehaviour
{
    public GameObject Panel;

    public void Start()
    {
        Panel.SetActive(false);
    }

    public void OnMouseOver()
    {
        Panel.SetActive(true);
    }

    public void OnMouseExit()
    {
        Panel.SetActive(false);
    }
}
