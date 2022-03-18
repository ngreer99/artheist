using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class BaseController : MonoBehaviour
{
    public float speed;
    public bool grounded;
    public LayerMask groundLayers;
    public float groundRayLength = 0.1f;
    public float groundRaySpread = 0.1f;
    [HideInInspector] public Vector2 relativeVelocity = new Vector2();

    protected Rigidbody2D rb2d;

    public virtual void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void LoadNextLevel(int x)
    {
        SceneManager.LoadScene(x);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        BaseController controller = collision.gameObject.GetComponent<BaseController>();
        if (controller != null)
        {
            Vector3 impactDirection = collision.gameObject.transform.position - transform.position;
            Hurt(impactDirection);
        }
    }

    protected abstract void Hurt(Vector3 impactDirection);
}

