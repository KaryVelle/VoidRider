using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class ObstacleController : MonoBehaviour
{
  public GameObject obstacle;
  public float radio;
  public int maxEnemies;
  public List<GameObject> obstacleList;

  private void Start()
  {
    float total = Random.Range(1, maxEnemies);
    for (int i = 0; i <= total; i++)
    {
      Vector3 randomPos = new Vector3(Random.Range(-1000f, 1000f), Random.Range(-1000f,1000f), Random.Range(-1000f,1000f));
      if (IsPositionEmpty(randomPos))
      {
        GameObject NewInst = Instantiate(obstacle, randomPos, Quaternion.identity);
        obstacleList.Add(NewInst);
      }
    }
  }
  
  bool IsPositionEmpty(Vector3 position)
  {
    foreach (var obstacle in obstacleList)
    {
      if (Vector3.Distance(position, obstacle.transform.position) < radio)
      {
        return false;
      }
    }

    return true;
  }

}
