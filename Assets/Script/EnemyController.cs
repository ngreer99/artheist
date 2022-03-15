using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//artheist 

public class Boundary
{
    public float xMin, xMax;
}

public class EnemyController : MonoBehaviour
{
    //public float ledgeTestLeft;
    //public float ledgeTestRight;

    private int direction = 1;
    //private float walkTimer = 0;

    public Transform transformx;
    private Vector3 xAxis;
    private float secondsForOneLength = 1f;
    public Boundary boundary;
    

    void Update()
    {
        //UpdateGrounding();
        //UpdateDirection();

        //Vector2 vel = rb2d.velocity;
        //vel.x = direction * speed;
        //rb2d.velocity = vel;
        //relativeVelocity = vel;

        transform.position = new Vector3(Mathf.PingPong(boundary.xMin, boundary.xMax), transform.position.y, transform.position.z);
        
    }


    /*int UpdateDirection()
    {
       
        walkTimer -= Time.deltaTime;
        if (walkTimer <= 3.0f)
        {
            direction = -1;
        }
        

        Vector3 ledgeRayStartLeft = transform.position + Vector3.up * groundRayLength + Vector3.left * ledgeTestLeft;
        Vector3 ledgeRayStartRight = transform.position + Vector3.up * groundRayLength + Vector3.right * ledgeTestRight;

        Debug.DrawLine(ledgeRayStartLeft, ledgeRayStartLeft + Vector3.down * groundRayLength * 2, Color.blue);
        Debug.DrawLine(ledgeRayStartRight, ledgeRayStartRight + Vector3.down * groundRayLength * 2, Color.blue);

        RaycastHit2D hitLeft = Physics2D.Raycast(ledgeRayStartLeft, Vector2.down, groundRayLength * 2, groundLayers);
        RaycastHit2D hitRight = Physics2D.Raycast(ledgeRayStartRight, Vector2.down, groundRayLength * 2, groundLayers);

        if (hitLeft.collider == null)
        {
            direction = 1;
        }

        if (hitRight.collider == null)
        {
            direction = -1;
        }
        return direction;
        
        
    }*/
    void OnTriggerEnter(Collider Player)
    {
        Destroy(Player.gameObject);
    }

    /*protected override void Hurt(Vector3 impactDirection)
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
    */
}
