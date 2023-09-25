using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private ParticleSystem explosion;
    [SerializeField] private GameObject joint;

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("boom");
        Destroy(GetComponent<FixedJoint>());
        Instantiate(explosion, transform.position, transform.rotation);
        StartCoroutine(Destruye());
    }

    IEnumerator Destruye()
    {
        yield return new WaitForSeconds(3);
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(joint);
        Destroy(gameObject);
    }
}
