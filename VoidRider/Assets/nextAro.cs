using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextAro : MonoBehaviour
{
    public GameObject nextAro1;
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            nextAro1.SetActive(true);
        }
    }
}
