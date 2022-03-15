using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Art : MonoBehaviour
{
    public AudioClip coinsound;
    private AudioSource audioSource;

    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            PlayerController controller = other.gameObject.GetComponent<PlayerController>();
            Destroy(gameObject);
            // audioSource.PlayOneShot(coinsound);




        }

    }


}
