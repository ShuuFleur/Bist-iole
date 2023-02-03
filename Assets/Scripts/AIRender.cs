using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AIRender : MonoBehaviour
{
    public AIPath aiPath;

    private Vector2 _direction;

    private Animator _animator;
    
    
    // Start is called before the first frame update
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        faceVelocity();
    }

    private void faceVelocity()
    {
        _direction = aiPath.desiredVelocity;
        Vector2 dir = Vector2.zero;


        if (_direction.y > 0)
        {
            dir.y = 1;
            _animator.SetInteger("Direction", 1);
        }
        else if(_direction.y < 0)
        {
            dir.y = -1;
            _animator.SetInteger("Direction", 0);
        }

        print(dir);

    }

    public void Spawning()
    {
        _animator.Play("AM IA In");
        StartCoroutine(Spawned());
    }

    public IEnumerator Spawned() {

        yield return new WaitForSeconds(0.3f);
        aiPath.canMove = true;

    }
}
