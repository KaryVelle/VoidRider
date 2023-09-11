using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class BulletToUse : Bullet
{
    private void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);    
    }

    private void Update()
    {
        RB.AddForce(transform.forward * Speed);
        Destroy(gameObject, Range);
    }

}
