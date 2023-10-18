using System.Collections;
using UnityEngine;

public class Turbo : MonoBehaviour
{
    public ParticleSystem warp;
    public ParticleSystem warp2;
    public bool isTurbo;
    private Coroutine corTurbo;
    public Transform target;

    void Start()
    {
        warp.Stop();
        warp2.Stop();
    }

    public void TurboPressed()
    {
        if (corTurbo == null)
        {
            corTurbo = StartCoroutine(TurboWait());
        }
    }

    public IEnumerator TurboWait()
    {
        isTurbo = true;
        
        warp.Play();
        warp2.Play();

        yield return new WaitForSeconds(5);
        isTurbo = false;
        
        warp.Stop();
        warp2.Stop();

        corTurbo = null;
    }
    
}