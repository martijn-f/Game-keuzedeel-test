using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollectorHP : MonoBehaviour
{
    

    

    [SerializeField] private AudioSource collectionSoundEffect;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Heart"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            
        }
    }
}

