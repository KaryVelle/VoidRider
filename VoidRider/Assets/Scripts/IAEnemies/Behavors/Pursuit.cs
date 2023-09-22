using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuit : Steering
{
    public int T = 3;
    public GameObject pursuitTarget;
    public bool evade = false;
    [SerializeField] private Rigidbody _pController;


    // Start is called before the first frame update
    void Start()
    {

    }

    public override Vector3 GetForce()
    {
        if(!evade)
        {
            Vector3 direction = _pController.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = lookRotation;
            DesiredVelocity = (Target - Position).normalized * speed + Seek(); ;
            return DesiredVelocity - Velocity;
        }
        else 
        {
            Vector3 direction = _pController.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(direction *-1);
            transform.rotation = lookRotation;
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
