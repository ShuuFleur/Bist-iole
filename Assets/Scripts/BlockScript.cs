using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BlockScript : MonoBehaviour
{
    public Tilemap tiles;
    private Vector3 nextPos;
    
    public void OnInteract()
    {

        nextPos = new Vector3(transform.position.x, transform.position.y + 0.75f);
        Vector3Int tile = tiles.WorldToCell(nextPos);

        if (tiles.GetTile(tile))
        {
            nextPos = new Vector3(transform.position.x, (transform.position.y + 0.75f) + 1);
            tile = tiles.WorldToCell(nextPos);
            if (tiles.GetTile(tile))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 1);
                print("Haut");
                return;
            }
            
            nextPos = new Vector3(transform.position.x, (transform.position.y + 0.75f) - 1);
            tile = tiles.WorldToCell(nextPos);
            if (tiles.GetTile(tile))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 1);
                print("Bas");
                return;
            }
            
            nextPos = new Vector3(transform.position.x - 1, (transform.position.y + 0.75f));
            tile = tiles.WorldToCell(nextPos);
            if (tiles.GetTile(tile))
            {
                transform.position = new Vector3(transform.position.x - 1, transform.position.y);
                print("Gauche");
                return;
            }
            
            nextPos = new Vector3(transform.position.x + 1, (transform.position.y + 0.75f));
            tile = tiles.WorldToCell(nextPos);
            if (tiles.GetTile(tile))
            {
                transform.position = new Vector3(transform.position.x + 1, transform.position.y);
                print("Droite");
            }

        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(new Vector3(transform.position.x, transform.position.y + 0.75f), 0.25f);
    }
}
