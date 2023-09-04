using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Joystic_Char : MonoBehaviour
{
    public Transform parentObject;
    public float direccionX;
    public float direccionY;
    private XRGrabInteractable grabInteractable;
    [SerializeField] private Vector2 LimitsX;
    [SerializeField] private Vector2 LimitsY;
    [SerializeField] private Vector2 desiredLimit;
    private Vector3 parentSize;
    private Vector3 _inicialPocicion;
    // Start is called before the first frame update
    void Start()
    {
        _inicialPocicion = transform.position;
        grabInteractable = GetComponent<XRGrabInteractable>();
        parentSize = parentObject.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.localPosition.x);
        Vector3 relativePosition = parentObject.InverseTransformPoint(transform.position);

        float clampedX = Mathf.Clamp(relativePosition.x, -parentSize.x, parentSize.x);
        float clampedY = Mathf.Clamp(relativePosition.y, -parentSize.y, parentSize.y);
        float clampedZ = Mathf.Clamp(relativePosition.z, -parentSize.z, parentSize.z);

        Vector3 clampedPosition = parentObject.TransformPoint(new Vector3(clampedX, clampedY, clampedZ));
        transform.position = clampedPosition;

        if (transform.position.x != 0)
        {
            direccionX = (transform.localPosition.x - LimitsX.x) / (LimitsX.y - LimitsX.x) * (desiredLimit.x - desiredLimit.y) + desiredLimit.y;
            direccionY = (transform.localPosition.y - LimitsY.x) / (LimitsY.y - LimitsY.x) * (desiredLimit.x - desiredLimit.y) + desiredLimit.y;
            Debug.Log(direccionX +", " + direccionY);
            /*Debug.Log(transform.localPosition.x);
            Debug.Log(transform.localPosition.y);*/
        }


        if(grabInteractable.isSelected == false)
            transform.position = _inicialPocicion;

    }

    private void CalculateDirecction()
    {
        direccionX = transform.localPosition.x;
        Debug.Log(direccionX);
    }

}
