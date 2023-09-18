using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownButton : PlayerSettings
{
    [SerializeField] public bool upPressed = false;
    [SerializeField] public bool downPressed = false;
    [SerializeField] public bool rightPressed = false;
    [SerializeField] public bool leftPressed = false;
    public UpDownChanger upDownChanger;
    
    [SerializeField] public float rotDegrees = 0.5f;
 
   

    // Update is called once per frame
    void Update()
    {
       
       
            if (upPressed)
            {
                if (upDownChanger.invertYAxis)
                {
                    cabinRigidbody.transform.eulerAngles = new Vector3(
                        cabinRigidbody.transform.eulerAngles.x + rotDegrees,
                        cabinRigidbody.transform.eulerAngles.y ,
                        cabinRigidbody.transform.eulerAngles.z) ;
                }
                else
                {
                    cabinRigidbody.transform.eulerAngles = new Vector3(
                        cabinRigidbody.transform.eulerAngles.x - rotDegrees,
                        cabinRigidbody.transform.eulerAngles.y ,
                        cabinRigidbody.transform.eulerAngles.z) ;
                }
                   

                

                
            }
            
            if (downPressed)
            {
                if (upDownChanger.invertYAxis)
                {
                    cabinRigidbody.transform.eulerAngles = new Vector3(
                        cabinRigidbody.transform.eulerAngles.x - rotDegrees,
                        cabinRigidbody.transform.eulerAngles.y ,
                        cabinRigidbody.transform.eulerAngles.z) ;
                }
                else
                {
                    cabinRigidbody.transform.eulerAngles = new Vector3(
                        cabinRigidbody.transform.eulerAngles.x + rotDegrees,
                        cabinRigidbody.transform.eulerAngles.y ,
                        cabinRigidbody.transform.eulerAngles.z) ;
                }
                    
            }
            
            if (rightPressed)
            {
               
                cabinRigidbody.transform.eulerAngles = new Vector3(
                    cabinRigidbody.transform.eulerAngles.x ,
                    cabinRigidbody.transform.eulerAngles.y + rotDegrees ,
                    cabinRigidbody.transform.eulerAngles.z) ;
            }
            
            if (leftPressed)
            {
               
                cabinRigidbody.transform.eulerAngles = new Vector3(
                    cabinRigidbody.transform.eulerAngles.x ,
                    cabinRigidbody.transform.eulerAngles.y - rotDegrees ,
                    cabinRigidbody.transform.eulerAngles.z) ;
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
   

