using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemy;
    [SerializeField] private int desiredEnemys;
    private int[] positions = new int[] { 800, 800, 800 };
    public List<GameObject> enemies;
    void Start()
    {
        Generator(enemy[0]);
        Generator(enemy[1]);
        Generator(enemy[2]);
    }

    public void Generator(GameObject spawnEnem)
    {
        for(int i =0; i < desiredEnemys; i++)
        {
            GameObject a = Instantiate(spawnEnem) as GameObject;
            a.transform.position = new Vector3(Random.Range(-positions[0], positions[0]), 
                Random.Range(-positions[1], positions[1]), 
                Random.Range(-positions[2], positions[2]));
            enemies.Add(a);
        }
    }
}
