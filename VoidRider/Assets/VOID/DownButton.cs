using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownButton : MonoBehaviour
{
    [SerializeField] private bool downPressed = false;

    [SerializeField] Rigidbody cabin_Rigidbody;

    [SerializeField] private float rotDegrees = 0.5f;
   

    // Update is called once per frame
    void Update()
    {
        if (downPressed)
        {
            cabin_Rigidbody.transform.eulerAngles = new Vector3(
                cabin_Rigidbody.transform.eulerAngles.x - rotDegrees, cabin_Rigidbody.transform.eulerAngles.y,
                cabin_Rigidbody.transform.eulerAngles.z);
        }
        if (downPressed!)
        {
            cabin_Rigidbody.transform.eulerAngles = new Vector3(cabin_Rigidbody.transform.eulerAngles.x,
                cabin_Rigidbody.transform.eulerAngles.y, cabin_Rigidbody.transform.eulerAngles.z);
                
        }
    }
    
    void Down()
    {
        downPressed = true;

    }

    void NotDown()
    {
       downPressed= false;

    }
}
