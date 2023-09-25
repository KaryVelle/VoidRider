using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Turbo : PlayerSettings
{
    public int turboTimer = 5;
    public bool isTurbo;
    private Coroutine corTurbo;
    public void TurboPressed()
    {
        /*if (corTurbo != null)
        {
            StopCoroutine(corTurbo);
        }
        corTurbo = StartCoroutine(TurboWait());*/
        if (corTurbo == null)
        {
            corTurbo = StartCoroutine(TurboWait());
        }
    }

    public IEnumerator TurboWait()
    {
        isTurbo = true;
        yield return new WaitForSeconds(5);
        isTurbo = false;
        corTurbo = null;
    }
}
