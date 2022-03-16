using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Art : MonoBehaviour
{
    public AudioClip coinsound;
    private AudioSource audioSource;
    SpriteRenderer sRenderer;

    private void Start()
    {
        Gateway gate = FindObjectOfType<Gateway>();
        if(gate!=null) gate.AddArt();
        sRenderer = GetComponent<SpriteRenderer>();
    }

    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.gameObject.GetComponent<PlayerController>();
         if (controller != null){
            controller.CollectArt(); //sound
            Gateway gate = FindObjectOfType<Gateway>();
            if(gate!=null) gate.ArtCollected(); 
        }
        if (other.CompareTag("Player"))
        {
            PlayerController controller1 = other.gameObject.GetComponent<PlayerController>();
            Destroy(gameObject);
            // audioSource.PlayOneShot(coinsound);

        }

       

    }


}
