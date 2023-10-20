using System;
using UnityEngine;

public class NumberofEnemies : MonoBehaviour
{
    public EnemyCounter enemyCounter;

    private void Start()
    {
        enemyCounter = GetComponent<EnemyCounter>();
    }

    private void OnDestroy()
    {
      enemyCounter.numberOfEnemies =-1;
    }
}
