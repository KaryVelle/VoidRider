using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private int desiredEnemys;
    private int[] positions = new int[] { 8000, 8000, 8000 };
    public List<GameObject> enemies;
    public EnemyCounter EnemyCounter;
    void Start()
    {
        Generator();
        EnemyCounter.numberOfEnemies = enemies.Count;
    }
    

    public void Generator()
    {
        for(int i =0; i < desiredEnemys; i++)
        {
            GameObject a = Instantiate(enemy) as GameObject;
            a.transform.position = new Vector3(Random.Range(-positions[0], positions[0]), 
                Random.Range(-positions[1], positions[1]), 
                Random.Range(-positions[2], positions[2]));
            enemies.Add(a);
        }
    }
}
