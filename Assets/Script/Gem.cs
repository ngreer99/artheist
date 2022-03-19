using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    private SpriteRenderer sRenderer;
    public Sprite[] Gems;
    public float animationFPS;
    private float frameTimer = 0;
    private int frameIndex = 0;
    private int count = 0;

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
            frameIndex %= Gems.Length;
            sRenderer.sprite = Gems[frameIndex];
            if (count == 0)
            {
                transform.localScale *= 1.25f;
                count++;
            }
            else
            {
                transform.localScale *= .8f;
                count--;
            }
            frameIndex++;
        }
    }
}
