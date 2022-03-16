using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gateway : MonoBehaviour
{

    public string levelUp = "";
    public Sprite closedSprite;
    //public Sprite[] openAnimation;
    //public float animationFPS = 5;
    //private float frameTimer = 0;
    //private int frameIndex = 0;
    private SpriteRenderer sRenderer;

    public bool collectMinToOpen = true;
    private int numArt = 0; 
    private int minArt = 1;//min number pieces of art needed

    private bool isOpen = false;

    private void Awake()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        Open();
    }
    // Start is called before the first frame update
    void Start()
    {
        if(levelUp == "")
        {
            levelUp = SceneManager.GetActiveScene().name;
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        if (isOpen)
        {
            frameTimer -= Time.deltaTime;
            if (frameTimer <= 0.0f)
            {
                frameTimer = 1 / animationFPS;
                frameIndex %= openAnimation.Length;
                sRenderer.sprite = openAnimation[frameIndex];
                frameIndex++;
            }
        }
    }*/

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!isOpen) return;

        BaseController controller = other.gameObject.GetComponent<BaseController>();
        if (controller != null){
            SceneManager.LoadScene(levelUp);
        }
    }

    public void AddArt() //counts all of art pieces in maze
    {
        numArt++;
        if (collectMinToOpen) 
        {
            Close();
        }
    }

    public void ArtCollected()
    {
        numArt--; //subtract for each piece collected
        if(numArt >= minArt) //if pieces of collected is greater than or equal to min art, then open
        {
            Open();
        }
    }

    private void Open()
    {
        isOpen = true;
    }

    private void Close()
    {
        isOpen = false;
        sRenderer.sprite = closedSprite;
    }
}
