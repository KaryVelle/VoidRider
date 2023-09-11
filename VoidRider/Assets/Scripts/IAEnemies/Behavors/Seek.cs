using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : Steering
{
    public bool arrival = false;
    public float slowingRadius = 3f;
    public override Vector3 GetForce()
    {
        DesiredVelocity = (Target - Position);
        float distance = DesiredVelocity.magnitude;
        if(arrival && slowingRadius < distance )
        {
            DesiredVelocity = (Target - Position).normalized * speed *(distance/slowingRadius);
            return DesiredVelocity - Velocity;
        }
        else
        {
            DesiredVelocity = (Target - Position).normalized * speed;
            return DesiredVelocity - Velocity;
        }
    }
}
