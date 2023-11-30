using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyCounter : MonoBehaviour
{
    public int numberOfEnemies;
    public Text enemyTxt;
    public GameObject win;
    public TextMeshProUGUI puntaje;
    public TimerGame timer; 
    

    public void Update()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag("Enemy");
        numberOfEnemies = objectsWithTag.Length;
        enemyTxt.text = numberOfEnemies.ToString();
        if (objectsWithTag.Length == 0)
        {
            win.SetActive(true);
            puntaje.text = timer.timeToKeep.ToString();
            Time.timeScale = 0;
        }
    }
}
