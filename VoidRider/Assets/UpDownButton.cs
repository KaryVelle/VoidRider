using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownButton : MonoBehaviour
{
    [SerializeField] private bool upPressed;
    [SerializeField] private bool downPressed;
    [SerializeField] private Rigidbody cabin_Rigidbody;
    [SerializeField] private float rotDegrees;


    // Update is called once per frame
    void Update()
    {
        if (upPressed)
        {
            cabin_Rigidbody.transform.eulerAngles = new Vector3(cabin_Rigidbody.transform.eulerAngles.x + rotDegrees,
                cabin_Rigidbody.transform.eulerAngles.y, cabin_Rigidbody.transform.eulerAngles.z);
        }

        if (upPressed!)
        {
            rotDegrees = 0;

            cabin_Rigidbody.transform.eulerAngles = new Vector3(cabin_Rigidbody.transform.eulerAngles.x + rotDegrees,
                cabin_Rigidbody.transform.eulerAngles.y, cabin_Rigidbody.transform.eulerAngles.z);

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
                rotDegrees = 0;
            }
        }

    }
    
    void Up()
    {
        upPressed = true;

    }

    void NotUp()
    {
        upPressed = false;

    }

    void Down()
    {
        upPressed = true;

    }

    void NotDown()
    {
        upPressed = false;

    }
}
   

