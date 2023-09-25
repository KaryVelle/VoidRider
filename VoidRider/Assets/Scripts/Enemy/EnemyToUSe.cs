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
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Bullet")
        {
            Debug.LogWarning("quepedo");
            HP -= Bala.Damage;
            if (HP <= 0) Destroy(gameObject);
            //DestroyAnim.Play();
            //Destroy(gameObject);
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
