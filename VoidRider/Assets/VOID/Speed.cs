using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
[SerializeField] private Slider mySlider;


[SerializeField] private Rigidbody cabin_Rigidbody;
[SerializeField] private int maxSpeed;

// Start is called before the first frame update
    void Start()
    {
        mySlider = GetComponent<Slider>();
        if (mySlider == null) Debug.Log("No Slider");
    }
    
    public void OnValueChanged(float value)
    {
        Debug.Log(value);
        float speed = value;
        cabin_Rigidbody.velocity = cabin_Rigidbody.transform.forward * speed * maxSpeed;
        
    }
}
