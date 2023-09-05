using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba_Explosion : MonoBehaviour
{
    [SerializeField] private ParticleSystem explosion;
    

    private void OnCollisionEnter(Collision collision)
    {
        
        Instantiate(explosion, transform.position, transform.rotation);
        Debug.Log("boom");
        explosion.Play();
        Destroy(gameObject);
    }
}
