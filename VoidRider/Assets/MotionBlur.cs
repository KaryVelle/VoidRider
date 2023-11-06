using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionBlur : MonoBehaviour
{
    public GameObject targ;

    public void OnValueChanged(bool on)
    {
        targ.SetActive(on);
    }
}
