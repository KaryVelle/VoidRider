using UnityEngine;
using UnityEngine.UI;

public class Speed : MonoBehaviour
{
    [SerializeField] private Slider mySlider;
    [SerializeField] private Rigidbody cabin_Rigidbody;
    [SerializeField] private int maxSpeed;
    [SerializeField] private Vector3 RelativeFwd;
    [SerializeField] private float speed;

// Start is called before the first frame update
    void Start()
    {
        mySlider = GetComponent<Slider>();
        if (mySlider == null) Debug.Log("No Slider");
    }

    private void Update()
    {
        RelativeFwd = cabin_Rigidbody.transform.TransformDirection(Vector3.forward);
        Debug.Log(RelativeFwd);
        cabin_Rigidbody.velocity = RelativeFwd * speed * maxSpeed;
        Debug.Log(speed);
    }


    public void OnValueChanged(float value)
    {

        speed = value;
        //cabin_Rigidbody.velocity = cabin_Rigidbody.transform.forward * speed * maxSpeed;


    }
}
