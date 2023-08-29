using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystic_Char : MonoBehaviour
{
    public Transform parentObject;
    public float direccion;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 parentSize = parentObject.localScale;
        Vector3 relativePosition = parentObject.InverseTransformPoint(transform.position);

        float clampedX = Mathf.Clamp(relativePosition.x, -parentSize.x, parentSize.x);
        float clampedY = Mathf.Clamp(relativePosition.y, -parentSize.y, parentSize.y);
        float clampedZ = Mathf.Clamp(relativePosition.z, -parentSize.z, parentSize.z);

        Vector3 clampedPosition = parentObject.TransformPoint(new Vector3(clampedX, clampedY, clampedZ));
        transform.position = clampedPosition;

        if(transform.position.x<0)
        {
            direccion = (transform.localPosition.x * -1) / -parentSize.x;
            Debug.Log("izquierda" + direccion);
        }

    }
}
