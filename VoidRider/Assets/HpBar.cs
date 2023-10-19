using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    public Slider hpSlider;
    public float hp_bar;
    public float value;


    private void Update()
    {
        value = hp_bar / 100;
        hpSlider.value = value;
    }
}
