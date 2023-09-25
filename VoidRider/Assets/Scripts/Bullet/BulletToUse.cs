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

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Enemy")
        Destroy(gameObject);
    }

    private void Update()
    {
        RB.AddForce(Vector3.forward * Speed);
        Destroy(gameObject, Range);
    }

}
