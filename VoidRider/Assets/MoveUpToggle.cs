using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpToggle : MonoBehaviour
{

    [SerializeField] private bool isPressed;
    [SerializeField] private Rigidbody cabin_Rigidbody;
    [SerializeField] private float rotDegrees = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPressed)
        {
            cabin_Rigidbody.transform.eulerAngles = new Vector3(
                cabin_Rigidbody.transform.eulerAngles.x + rotDegrees, cabin_Rigidbody.transform.eulerAngles.y,
                cabin_Rigidbody.transform.eulerAngles.z);
            
        }
        
    }
    public void OnValueChanged(bool value)
    {

        isPressed = value;
        Debug.Log(isPressed);


    }
}
