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

    // Start is called before the first frame update
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        frameTimer -= Time.deltaTime;
        transform.localScale *= 0.9f;
        if (frameTimer <= 0.0f)
        {
            int count = 0;
            frameTimer = 1 / animationFPS;
            frameIndex %= Gems.Length;
            sRenderer.sprite = Gems[frameIndex];
            if (count == 1)
            {
                transform.localScale *= 1.5f;
                count--;
            }
            else{
                count++;
            }
            
            frameIndex++;
        }
    }
}
