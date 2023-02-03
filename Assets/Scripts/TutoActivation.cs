using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoActivation : MonoBehaviour
{
    public GameObject TutoPanel;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            TutoPanel.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D col)
    {
        TutoPanel.SetActive(false);
    }
}
