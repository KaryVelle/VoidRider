using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButtons : MonoBehaviour
{
    [SerializeField] private GameObject cabina;
    [SerializeField] private float turnSpeed = 5f;
    
    // Start is called before the first frame update
    public void Up()
    {
        cabina.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
    }
}
