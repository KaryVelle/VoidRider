using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private int desiredEnemys;
    [SerializeField] private float separtionRadious;
    private int[] positions = new int[] { 300, 300, 300 };
    public List<GameObject> enemies;
    // Start is called before the first frame update
    void Start()
    {
        Generator();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Generator()
    {
        for(int i =0; i < desiredEnemys; i++)
        {
            GameObject a = Instantiate(enemy) as GameObject;
            a.transform.position = new Vector3(Random.Range(-positions[0], positions[0]), Random.Range(-positions[1], positions[1]), Random.Range(-positions[2], positions[2]));
            enemies.Add(a);
        }
    }
}
