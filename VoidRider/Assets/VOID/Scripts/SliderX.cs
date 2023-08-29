using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderX : MonoBehaviour
{
    [SerializeField] private Slider mySlider;
    [SerializeField] private float maxRot;
    [SerializeField] private Rigidbody cabin_Rigidbody;
    [SerializeField] private float valueChanged;
    

// Start is called before the first frame update
    void Start()
    {
        mySlider = GetComponent<Slider>();
        if (mySlider == null) Debug.Log("No Slider");
    }
    
    public void OnValueChanged(float value)
    {
        valueChanged = value * maxRot;

        cabin_Rigidbody.transform.eulerAngles = new Vector3(valueChanged, cabin_Rigidbody.transform.eulerAngles.y,
            cabin_Rigidbody.transform.eulerAngles.z) ;
        
    }
}