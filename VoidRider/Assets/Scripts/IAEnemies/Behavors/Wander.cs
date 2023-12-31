using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : Steering
{
    public EnemyController enemyController;
    public Transform t_target;
    [SerializeField] private EnemyToUSe enemyToUSe;
    public float distanceToPlayer;
    public float circleDistance;
    public float circleRadius;
    public float[] targetChange = new float[] { 1f, 10f };
    public float[] targetSpace = new[] { 8f, 5f, 10f };
    public float[] angleChange = new[] { 1f, 20f };
    public float[] angleRange = new[] { -45f, 45f };
    public bool showVectors = true;
    private bool _startRandom = true;
    private float _rotationAngle = 10f;
    private Seek _seek;
    public float rotSpeed;

    private void Start()
    {
        t_target = FindObjectOfType<PlayerController>().gameObject.transform;
        enemyController = GetComponent<EnemyController>();
        enemyToUSe = GetComponent<EnemyToUSe>();
        _seek = GetComponent<Seek>();
        StartCoroutine(RandomTarget());
        StartCoroutine(RandomAngle());
    }

    public override Vector3 GetForce()
    {
        Vector3 circleCenter = Velocity.normalized * circleDistance;
        Vector3 displesment = Velocity.normalized * circleRadius;
        Quaternion rotate = Quaternion.AngleAxis(_rotationAngle, Vector3.forward);
        displesment = rotate * displesment;
        Target = circleCenter + displesment;
        float dimensions = gameObject.transform.localScale.x + gameObject.transform.localScale.y;
        DesiredVelocity = ((Target + _seek.Target) - Position).normalized * (speed/ dimensions);
        Vector3 direction = (Target + _seek.Target) - Position;
        Quaternion lookRotation = Quaternion.LookRotation(direction * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotSpeed); 
        distanceToPlayer = (t_target.position - transform.position).magnitude;
        if(distanceToPlayer < 150f && enemyToUSe.HP > 5)
        {
            enemyController.myState = EnemyController.EnemyState.Pursuit;
        }
        else if(distanceToPlayer < 150f && enemyToUSe.HP < 5)
        {
            enemyController.myState = EnemyController.EnemyState.Evade;
        }
        if (showVectors == true)
        {
            DrawVectors(circleCenter, displesment);
        }
        return DesiredVelocity - Velocity;
    }

    IEnumerator RandomTarget()
    {
        while (_startRandom)
        {
            Vector3 randomTarget = new Vector3(Random.Range(-targetSpace[0], 
                targetSpace[0]), Random.Range(-targetSpace[1], targetSpace[1]),
                Random.Range(-targetSpace[2], targetSpace[2]));
            _seek.Target = randomTarget;
            yield return new WaitForSeconds(Random.Range(targetChange[0], targetChange[1]));
        }
    }

    IEnumerator RandomAngle()
    {
        while (_startRandom)
        {
            _rotationAngle = Random.Range(angleRange[0], angleRange[1]);
            yield return new WaitForSecondsRealtime(Random.Range(angleChange[0], angleChange[1]));
        }
    }
    
    private void DrawVectors(Vector3 center, Vector3 displacement)
    {
        Debug.DrawLine(Position, Position + center, Color.green);
        Debug.DrawLine(Position + center, Position + center + displacement, Color.red);
        Debug.DrawLine(Position, Position + center + displacement, Color.blue);
    }
}
