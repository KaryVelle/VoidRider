using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject stats;
    public GameObject canva;
    public GameObject targ;
  
    void Start()
    {
        stats.SetActive(false);
        Time.timeScale = 0;
        targ.SetActive(false);
    }
    
    public void BeginGame()
    {
        stats.SetActive(true);
        Time.timeScale = 1;
        targ.SetActive(true);
        canva.SetActive(false);
    }
    
    public void BeginTutorials()
    {
        SceneManager.LoadScene("TutorialMove");
        Time.timeScale = 1;
    }
    
    
}
