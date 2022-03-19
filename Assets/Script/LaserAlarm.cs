using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAlarm : MonoBehaviour
{
    private SpriteRenderer sRenderer;
    public float animationFPS;
    public Sprite[] laserAnimation;
    private float frameTimer = 0;
    private int frameIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        frameTimer -= Time.deltaTime;
        if (frameTimer <= 0.0f)
        {
            frameTimer = 1 / animationFPS;
            frameIndex %= laserAnimation.Length;
            sRenderer.sprite = laserAnimation[frameIndex];
            frameIndex++;

        }

    }

}
