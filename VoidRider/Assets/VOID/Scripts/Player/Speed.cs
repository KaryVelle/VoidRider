using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Speed : PlayerSettings
{
    [SerializeField] private Slider mySlider;
    [SerializeField] private Vector3 relativeFwd;
    public Turbo turbo;
    public int turboMulti;
    
    


   void Start()
    {
        mySlider = GetComponent<Slider>();
        if (mySlider == null) Debug.Log("No Slider");
    }

    private void Update()
    {

        if (turbo.isTurbo)
        {
            relativeFwd = cabinRigidbody.transform.TransformDirection(Vector3.forward);
        
            cabinRigidbody.velocity = relativeFwd * speed * maxSpeed * turboMulti;
        }
        else
        {
            relativeFwd = cabinRigidbody.transform.TransformDirection(Vector3.forward);
        
            cabinRigidbody.velocity = relativeFwd * speed * maxSpeed;
        }
       
    }


    public void OnValueChanged(float value)
    {

        speed = value;
        
    }

  

  

}
