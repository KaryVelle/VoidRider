
using Newtonsoft.Json;
using UnityEngine;

public class UpDownChanger : MonoBehaviour
{
    public bool invertYAxis;

    public void OnValueChanged(bool value)
    {
        invertYAxis = value;
        Debug.Log(invertYAxis);
    }

}
