using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Speed : MonoBehaviour
{
    [SerializeField] private Slider mySlider;
    [SerializeField] private Rigidbody cabin_Rigidbody;
    [SerializeField] private int maxSpeed;
    [SerializeField] private Vector3 relativeFwd;
    [SerializeField] public float speed;


    [SerializeField] public bool turboPressed;
    [SerializeField] private float turboMulti;
    
    
    


   void Start()
    {
        mySlider = GetComponent<Slider>();
        if (mySlider == null) Debug.Log("No Slider");
    }

    private void Update()
    {
        relativeFwd = cabin_Rigidbody.transform.TransformDirection(Vector3.forward);
        
        cabin_Rigidbody.velocity = relativeFwd * speed * maxSpeed;
       
    }


    public void OnValueChanged(float value)
    {

        speed = value;
        //cabin_Rigidbody.velocity = cabin_Rigidbody.transform.forward * speed * maxSpeed;
    }

    public void TurboPressed()
    {
        turboPressed = true;
    }

    private IEnumerator TurboTimer()
    {
        yield return new WaitForSeconds(10);
        turboPressed = false;
    }

}
