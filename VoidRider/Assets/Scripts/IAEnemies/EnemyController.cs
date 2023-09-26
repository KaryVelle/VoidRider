using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private BehavorController behavorController;
    [SerializeField] private Wander wander;
    [SerializeField] private Pursuit pursuit;
    [SerializeField] private EnemyToUSe enemyToUSe;
    public Steering stering;
    public GameObject target;
    public enum EnemyState
    {
        Idle,
        Pursuit,
        Evade,
        Attack
    }
    public EnemyState myState;
    // Start is called before the first frame update
    void Start()
    {
        behavorController = GetComponent<BehavorController>();
        pursuit = GetComponent<Pursuit>();
        wander = GetComponent<Wander>();
        enemyToUSe = GetComponent<EnemyToUSe>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (myState)
        {
            case EnemyState.Idle:
                behavorController.behavors[0] = wander;
                pursuit.enabled = false;
                wander.enabled = true;
                enemyToUSe.Fire = false;
                break;
            case EnemyState.Pursuit:
                behavorController.behavors[0] = pursuit;
                pursuit.evade = false;
                pursuit.enabled = true;
                wander.enabled = false;
                enemyToUSe.Fire = false;
                break;
            case EnemyState.Evade:
                behavorController.behavors[0] = pursuit;
                pursuit.evade = true;
                pursuit.enabled = true;
                wander.enabled = false;
                enemyToUSe.Fire = false;
                break;
            case EnemyState.Attack:
                behavorController.behavors[0] = pursuit;
                pursuit.evade = false;
                pursuit.enabled = true;
                wander.enabled = false;
                enemyToUSe.Fire = true;
                if ((target.transform.position - transform.position).magnitude < 30f)
                    myState = EnemyState.Evade;
                break;

        }
        stering.Target = target.transform.position;
        //myState = EnemyState.Evade;
    }

   
    void EvaluateState()
    {
        //if(hp<1)
        //{ myState = EnemyState.Evade; }
    }
}
