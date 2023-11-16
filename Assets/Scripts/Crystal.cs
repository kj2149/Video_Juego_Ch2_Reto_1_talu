using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip sonido;
    [SerializeField] private GameObject particulas;

    
   
    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.CompareTag("Player"))

        {
            audioSource.PlayOneShot(sonido);

            Instantiate(particulas, transform.position, transform.rotation);

            Destroy(gameObject);

        }


    }


}

