using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Turbo : PlayerSettings
{
    public int turboTimer = 5;
    public bool isTurbo;

    private void Update()
    {
        if (isTurbo)
        {
            TurboWait();
        }
    }

    public void TurboPressed()
    {
        isTurbo = true;
        

    }

    public IEnumerator TurboWait()
    {
        
        yield return new WaitForSeconds(5);
        isTurbo = false;
        
    }
}
