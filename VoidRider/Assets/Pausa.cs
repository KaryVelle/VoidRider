using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pausa : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pauseWarn;
   

    public void TogglePause()
    {
        if (isPaused)
        {
            Time.timeScale = 1.0f;
            isPaused = false;
            pauseWarn.SetActive(false);
        }
        else
        {
            Time.timeScale = 0.0f;
            isPaused = true;
            pauseWarn.SetActive(true);
        }
    }
}
