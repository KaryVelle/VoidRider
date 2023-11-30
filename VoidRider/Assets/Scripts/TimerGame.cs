using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerGame : MonoBehaviour
{
    public float timeToKeep;

    void Update()
    {
        timeToKeep += Time.deltaTime;
    }
}
