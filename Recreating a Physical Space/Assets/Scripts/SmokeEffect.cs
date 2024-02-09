using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trigger")
        {
            _particleSystem.Play();
            Destroy(other.gameObject);
        }
    }
}
