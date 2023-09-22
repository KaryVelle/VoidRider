using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Steering stering;
    public GameObject target;
    public enum EnemyState
    {
        Idle,
        Seek,
        Pursuit,
        Evade,
        Attack
    }
    public EnemyState myState;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (myState)
        {
            case EnemyState.Idle:

                break;
            case EnemyState.Pursuit:

                break;
        }
        stering.Target = target.transform.position;
        myState = EnemyState.Evade;
    }
    void EvaluateState()
    {
        //if(hp<1)
        //{ myState = EnemyState.Evade; }
    }
}
