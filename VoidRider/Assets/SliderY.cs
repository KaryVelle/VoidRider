
using System;
using UnityEngine;
using UnityEngine.UIElements;

public class SliderY : MonoBehaviour
{
[SerializeField] private float maxRot;
    [SerializeField] private Rigidbody cabin_Rigidbody;
    [SerializeField] private float valueChanged;
        
    
   

    private void Update()
    {
        cabin_Rigidbody.transform.eulerAngles = new Vector3( cabin_Rigidbody.transform.eulerAngles.x,valueChanged,
            cabin_Rigidbody.transform.eulerAngles.z) ;
    }

    public void OnValueChanged(float value)
    {
        valueChanged = value * maxRot;
    
        
        
    }
}
