
using UnityEngine;
using UnityEngine.UIElements;

public class SliderY : MonoBehaviour
{
    [SerializeField] public Slider mySliderY;
    [SerializeField] private float maxRot;
    [SerializeField] private Rigidbody cabin_Rigidbody;
    [SerializeField] private float valueChanged;
        
    
    // Start is called before the first frame update
    void Start()
    {
        mySliderY = GetComponent<Slider>();
        if (mySliderY == null) Debug.Log("No Slider");
    }
        
    public void OnValueChanged(float value)
    {
        valueChanged = value * maxRot;
    
        cabin_Rigidbody.transform.eulerAngles = new Vector3( cabin_Rigidbody.transform.eulerAngles.x,valueChanged,
            cabin_Rigidbody.transform.eulerAngles.z) ;
        
    }
}
