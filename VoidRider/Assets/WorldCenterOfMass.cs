using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCenterOfMass : MonoBehaviour
{
    public Rigidbody rb;

    private void Update()
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
        
    }
}
