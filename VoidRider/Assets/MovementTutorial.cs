
using System;
using UnityEngine;

public class MovementTutorial : MonoBehaviour
{
    public bool crossed;
    public GameObject nextAro;
    public bool aroFinal;
    public GameObject finger;
    public GameObject movementUI;
    private void OnTriggerEnter (Collider other)
    {

        if (other.CompareTag("Player"))
        {
            crossed = true;
            nextAro.SetActive(true);
            finger.SetActive(false);
            movementUI.SetActive(true);
            if (aroFinal)
            {
                Debug.Log("fin");
            }
            
        }
    }
}
