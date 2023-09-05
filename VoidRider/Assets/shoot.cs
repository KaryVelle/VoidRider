using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class shoot : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootFrom1;
    [SerializeField] private Transform shootFrom2;
    [SerializeField] private float speed;
    private Rigidbody rb1;
    private Rigidbody rb2;
    [SerializeField] private bool fire;

    public void Start()
    {
      
    }

    public void Update()
    {
        if (fire)
        {
            Shoot();
        }
    }


    public void Shoot()
    {
        GameObject bullet1= Instantiate(bulletPrefab, shootFrom1.position, Quaternion.Euler(0,0,0));
        rb1 = bullet1.GetComponent<Rigidbody>();
        rb1.AddForce(transform.forward * speed);
        Destroy(bullet1, 3);
        
        GameObject bullet2= Instantiate(bulletPrefab, shootFrom2.position, Quaternion.Euler(0,0,0));
        rb2 = bullet2.GetComponent<Rigidbody>();
        rb2.AddForce(transform.forward * speed);
        Destroy(bullet2, 3);
        

    }

   
}
