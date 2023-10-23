using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotate : MonoBehaviour
{

    [SerializeField] private GameObject target;
    [SerializeField] private float rotSpeed;

    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.left,  rotSpeed*Time.deltaTime);
    }
}
