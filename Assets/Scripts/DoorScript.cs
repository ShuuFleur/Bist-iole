using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Camera mainCamera;
    public Sprite doorOpen;
    public Sprite doorClose;
    public Sprite doorShadowOpen;
    public Sprite doorShadowClose;
    public bool isOpen;
    public AudioSource OpeningDoorSound;
    public AudioSource RockButtonSound;
    public Animator animator1;

    private SpriteRenderer _sprite;
    private SpriteRenderer _shadowSprite;
    private Collider2D _col;
    private GameObject _ownCamera;
    
    private void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _shadowSprite = transform.GetChild(0).GetComponent<SpriteRenderer>();
        _ownCamera = transform.GetChild(1).gameObject;
        _col = GetComponent<Collider2D>();
    }

    public void OpenDoor()
    {
        StartCoroutine(OpeningDoor());
        
    }

    private IEnumerator OpeningDoor()
    {
        isOpen = !isOpen;

        if (isOpen)
        {
            _sprite.sprite = doorOpen;
            _shadowSprite.sprite = doorShadowOpen;
            _col.enabled = false;
        }
        else
        {
            _sprite.sprite = doorClose;
            _shadowSprite.sprite = doorShadowClose;
            _col.enabled = true;
        }

        RockButtonSound.Play();
        animator1.SetTrigger("PillarActivation");
        yield return new WaitForSeconds(0.6f);

        mainCamera.enabled = false;
        _ownCamera.SetActive(true);
        OpeningDoorSound.Play();

        yield return new WaitForSeconds(1f);
        
        _ownCamera.SetActive(false);
        mainCamera.enabled = true;

    }
}
