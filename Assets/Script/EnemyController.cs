using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class EnemyController : BaseController
{

    private int direction = 1;
    private float walkTimer = 0;
    private SpriteRenderer sRenderer;


    public override void Start()
    {
        
        sRenderer = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        
        UpdateDirection();

        Vector2 vel = rb2d.velocity;
        vel.x = direction * speed;
        rb2d.velocity = vel;
        relativeVelocity = vel;
    }


    int UpdateDirection()
    {

        walkTimer += Time.deltaTime;
        if (walkTimer <= 2.0f)
        {
            sRenderer.flipX = false;
            direction = -1;
        }

        else
        {
            direction = 1;
            sRenderer.flipX = true;
        }
        if (walkTimer >= 4.0f)
            {
                walkTimer = 0;   
        }

        
        return direction;


    }


    protected override void Hurt(Vector3 impactDirection)
    {
        if (Mathf.Abs(impactDirection.x) > Mathf.Abs(impactDirection.y))
        {
            direction = (int)Mathf.Sign(-impactDirection.x);
        }
        else
        {
            if (impactDirection.y > 0.0f)
            {
                Destroy(gameObject);
            }
        }

    }
}