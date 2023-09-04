using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownButton : MonoBehaviour
{
    [SerializeField] private bool upPressed = false;
   
    [SerializeField] private Rigidbody cabin_Rigidbody;
    [SerializeField] private float rotDegrees = 0.5f;


    // Update is called once per frame
    void Update()
    {
       
          
        

       
        
       
    }

    public void UpPress()
    {
        
        Debug.Log("up");
    }

    public void UpNotPress()
    {
        Debug.Log("notup");
    }

  

  
    
}
   

