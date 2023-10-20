using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
    public int numberOfEnemies;
    public Text enemyTxt;
    

    public void Update()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Enemy");
        numberOfEnemies = objectsWithTag.Length;
        enemyTxt.text = numberOfEnemies.ToString();
      
    }
}
