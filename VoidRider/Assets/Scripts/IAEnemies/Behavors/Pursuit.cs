using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuit : Steering
{
    public int T = 3;
    public GameObject pursuitTarget;
    public bool evade = false;
    private PlayerController _pController;


    // Start is called before the first frame update
    void Start()
    {
        _pController = FindObjectOfType<PlayerController>();
    }

    public override Vector3 GetForce()
    {
        if(!evade)
        {
            DesiredVelocity = (Target - Position).normalized * speed + Seek(); ;
            return DesiredVelocity - Velocity;
        }
        else 
        {
            DesiredVelocity = Seek();
            return (DesiredVelocity + Velocity) * -1;
        }
    }

    private Vector3 Seek()
    {
        DesiredVelocity = (_pController.velocity + _pController.transform.position).normalized * T;
        return DesiredVelocity;
    }
}
