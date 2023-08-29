using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SliderX : MonoBehaviour
{
   
    [SerializeField] private float maxRot;
    [SerializeField] private Rigidbody cabin_Rigidbody;
    [SerializeField] private float valueChanged;
    private float rotDirection = 1;
    [SerializeField] private float time;
    private Vector3 debugger;
        
  

    private void Update()
    {
        debugger= Vector3.Lerp(cabin_Rigidbody.transform.eulerAngles,new Vector3(valueChanged  ,cabin_Rigidbody.transform.eulerAngles.y,
            cabin_Rigidbody.transform.eulerAngles.z) * rotDirection, time);

        cabin_Rigidbody.transform.eulerAngles = new Vector3(debugger.x, debugger.y, debugger.z);
        
        Debug.Log(debugger);
        
    }

    public void OnValueChanged(float value)
    {
       
        if(value < 50)
        {
            rotDirection *= -1;
        }
        else
        {
            rotDirection *= 1; 
        }
        
        valueChanged = value;

    }
}
