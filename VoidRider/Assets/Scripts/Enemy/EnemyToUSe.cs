using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyToUSe : Enemy
{
    private void Start()
    {
        Bala = BalaPrefab.GetComponent<BulletToUse>();
    }

    private void Update()
    {
        if(Fire)
        {
            Shot();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "bullet")
        {
            //DestroyAnim.Play();
            Destroy(gameObject);
        }
    }

    private void Shot()
    {
        Fire = false;
        Instantiate(BalaPrefab, shootPos1.position, Quaternion.Euler(0, 0, 0));
        StartCoroutine(DelayDeBala());
    }

    IEnumerator DelayDeBala()
    {
        yield return new WaitForSeconds(Delay);
        Fire = true;
    }
}
