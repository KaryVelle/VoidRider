using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VelocityModi : MonoBehaviour
{
    [SerializeField] Slider sliderValue;
    [SerializeField] private float _maxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0,0, _maxSpeed * sliderValue.value * Time.deltaTime);
    }
}
