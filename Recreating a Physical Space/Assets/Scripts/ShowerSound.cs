using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerSound : MonoBehaviour
{
    public AudioClip showerSound;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
       
        if(other.gameObject.tag == "Player")
        {
            audioSource.Play();
        }
    }
}
