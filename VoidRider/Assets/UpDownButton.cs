using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownButton : MonoBehaviour
{
    [SerializeField] public bool upPressed = false;
    [SerializeField] public bool downPressed = false;
    [SerializeField] public bool rightPressed = false;
    [SerializeField] public bool leftPressed = false;
   
    [SerializeField] public Rigidbody cabin_Rigidbody;
    [SerializeField] public float rotDegrees = 0.5f;
    
   



    // Update is called once per frame
    void Update()
    {
       
       
            if (upPressed)
            {
               
                cabin_Rigidbody.transform.eulerAngles = new Vector3(
                    cabin_Rigidbody.transform.eulerAngles.x - rotDegrees,
                    cabin_Rigidbody.transform.eulerAngles.y ,
                    cabin_Rigidbody.transform.eulerAngles.z) ;

                

                
            }
            
            if (downPressed)
            {
               
                cabin_Rigidbody.transform.eulerAngles = new Vector3(
                    cabin_Rigidbody.transform.eulerAngles.x + rotDegrees,
                    cabin_Rigidbody.transform.eulerAngles.y ,
                    cabin_Rigidbody.transform.eulerAngles.z) ;
            }
            
            if (rightPressed)
            {
               
                cabin_Rigidbody.transform.eulerAngles = new Vector3(
                    cabin_Rigidbody.transform.eulerAngles.x ,
                    cabin_Rigidbody.transform.eulerAngles.y + rotDegrees ,
                    cabin_Rigidbody.transform.eulerAngles.z) ;
            }
            
            if (leftPressed)
            {
               
                cabin_Rigidbody.transform.eulerAngles = new Vector3(
                    cabin_Rigidbody.transform.eulerAngles.x ,
                    cabin_Rigidbody.transform.eulerAngles.y - rotDegrees ,
                    cabin_Rigidbody.transform.eulerAngles.z) ;
            }
            
            


    }

    public void UpNotPress()
    {
        
        upPressed = false;

    }
    
    public void UpPressed()
    {
       
        upPressed = true;
    }
    
    public void DownNotPress()
    {
        
        downPressed = false;

    }
    
    public void DownPressed()
    {
        
        downPressed = true;
    }
    
    public void RightNotPress()
    {
        
        rightPressed = false;

    }
    
    public void RightPressed()
    {
       
        rightPressed = true;
    }
    
    public void LeftNotPress()
    {
        
        leftPressed = false;

    }
    
    public void LeftPressed()
    {
       
        leftPressed = true;
    }

   

  
    
}
   

