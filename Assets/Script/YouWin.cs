using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRb2D;

    // Start is called before the first frame update
    void Start()
    {
        myRb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = myRb2D.velocity;
        vel.x = speed;
        myRb2D.velocity = vel;
    }
}
