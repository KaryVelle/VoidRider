using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Joystic_Char : MonoBehaviour
{
    public Transform parentObject;
    public float direccion;
    private XRGrabInteractable grabInteractable;
    [SerializeField] private Vector2 globalPosition;

    private Vector3 _inicialPocicion;
    // Start is called before the first frame update
    void Start()
    {
        _inicialPocicion = transform.position;
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.localPosition.x);
        Vector3 parentSize = parentObject.localScale;
        Vector3 relativePosition = parentObject.InverseTransformPoint(transform.position);

        float clampedX = Mathf.Clamp(relativePosition.x, -parentSize.x, parentSize.x);
        float clampedY = Mathf.Clamp(relativePosition.y, -parentSize.y, parentSize.y);
        float clampedZ = Mathf.Clamp(relativePosition.z, -parentSize.z, parentSize.z);

        Vector3 clampedPosition = parentObject.TransformPoint(new Vector3(clampedX, clampedY, clampedZ));
        transform.position = clampedPosition;

        if (transform.position.x != 0)
        {
            direccion = (transform.position.x  - -parentSize.x) / (parentSize.x - parentSize.x) * (globalPosition.x - globalPosition.y) + globalPosition.y;
            Debug.Log(direccion);
        }


        if(grabInteractable.isSelected == false)
            transform.position = _inicialPocicion;

    }

}
