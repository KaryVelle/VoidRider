using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuit : Steering
{
    public EnemyController enemyController;
    [SerializeField] private EnemyToUSe enemyToUSe;
    public int T = 3;
    public GameObject pursuitTarget;
    public bool evade = false;
    [SerializeField] private Rigidbody _pController;

    Coroutine corScape;
    Coroutine corProxy;


    // Start is called before the first frame update
    void Start()
    {
        pursuitTarget = FindObjectOfType<PlayerController>().gameObject;
        _pController = pursuitTarget.GetComponent<Rigidbody>();
        enemyController = GetComponent<EnemyController>();
        enemyToUSe = GetComponent<EnemyToUSe>();
    }

    public override Vector3 GetForce()
    {
        if(!evade)
        {
            Vector3 direction = _pController.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = lookRotation;
            DesiredVelocity = (Target - Position).normalized * speed + Seek();
            if(enemyToUSe.HP < 5)
            {
                enemyController.myState = EnemyController.EnemyState.Evade;
            }
            if((_pController.position - transform.position).magnitude < 100f)
            {
                enemyController.myState = EnemyController.EnemyState.Attack;
            }
            if((_pController.position - transform.position).magnitude > 150f)
            {
                enemyController.myState = EnemyController.EnemyState.Idle;
            }
            return DesiredVelocity - Velocity;
        }
        else 
        {
            Vector3 direction = _pController.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(direction * -1);
            transform.rotation = lookRotation;
            DesiredVelocity = DesiredVelocity = (Target - Position).normalized * speed + Seek();
            if (enemyToUSe.HP > 5)
            {
                if (corProxy == null)
                {
                    corProxy = StartCoroutine(DelayProximity());
                    //StopCoroutine(corProxy);
                }
            }
            else
            {
                if(corScape == null)
                {
                    corScape = StartCoroutine(DelayScape());
                }
            }
            return (DesiredVelocity + Velocity) * -1;
        }
    }

    private Vector3 Seek()
    {
        DesiredVelocity = (_pController.velocity + _pController.transform.position).normalized * T;
        return DesiredVelocity;
    }

    IEnumerator DelayScape()
    {
        yield return new WaitForSeconds(5f);
        enemyController.myState = EnemyController.EnemyState.Idle;
        corScape = null;
    } 
    
    IEnumerator DelayProximity()
    {
        yield return new WaitForSeconds(2f);
        enemyController.myState = EnemyController.EnemyState.Pursuit;
        corProxy = null;
    }

}
