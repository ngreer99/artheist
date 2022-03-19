using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
<<<<<<< Updated upstream
<<<<<<< Updated upstream
    // Start is called before the first frame update
    void Start()
    {
        
=======
=======
>>>>>>> Stashed changes
    public float speed;
    private Rigidbody2D myRb2D;

    // Start is called before the first frame update
    void Start()
    {
        myRb2D = GetComponent<Rigidbody2D>();
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        transform.localPosition *= (1, 1, 1);
=======
        Vector2 vel = myRb2D.velocity;
        vel.x = speed;
        myRb2D.velocity = vel;
>>>>>>> Stashed changes
=======
        Vector2 vel = myRb2D.velocity;
        vel.x = speed;
        myRb2D.velocity = vel;
>>>>>>> Stashed changes
    }
}
