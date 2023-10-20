using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionBlur : MonoBehaviour
{
    public GameObject blur;
    public bool on;

    public void OnValueChanged(bool on)
    {
        blur.SetActive(on);
    }
}
