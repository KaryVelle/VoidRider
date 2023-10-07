using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyToUSe : Enemy
{
    [SerializeField] private FixedJoint joint;
    [SerializeField] private FixedJoint joint2;
    [SerializeField] private Rigidbody rbj1;
    [SerializeField] private Rigidbody rbj2;
    [SerializeField] private float speed;
    [SerializeField] private float rotSpeed;
    [SerializeField] private bool isDestroy = false;
    private BoxCollider _bc;
    private Coroutine shotDelay;

    private void Start()
    {
        Fire = false;
        Bala = BalaPrefab.GetComponent<BulletToUse>();
        _bc = GetComponent<BoxCollider>();
    }

    private void Update()
    {
        if(Fire)
        {
            Shot();
        }
        if(isDestroy)
        {
            rbj1.transform.Rotate(Vector3.one * rotSpeed * Time.deltaTime);
            rbj2.transform.Rotate(Vector3.one * rotSpeed * Time.deltaTime * -1);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "PlayerBullet")
        {
            Debug.LogWarning("quepedo");
            HP -= Bala.Damage;
            if (HP <= 0)
            {
                Destroy(joint);
                Destroy(joint2);
                _bc.enabled = false;
                isDestroy = true;
                rbj2.AddForce(Vector3.one * speed, ForceMode.Impulse);
                rbj1.AddForce((Vector3.one*-1 * speed), ForceMode.Impulse);
                Instantiate(DestroyAnim, transform.position, transform.rotation);
                StartCoroutine(Destruye());
            }

        }
    }

    private void Shot()
    {
        Fire = false;
        //BalaPrefab.transform.position = shootPos1.position;
        if(shotDelay == null)
        {
            Instantiate(BalaPrefab, shootPos1.position, shootPos1.rotation);
            shotDelay = StartCoroutine(DelayDeBala());
        }
    }

    IEnumerator DelayDeBala()
    {
        yield return new WaitForSeconds(Delay);
        shotDelay = null;
    }

    IEnumerator Destruye()
    {
        yield return new WaitForSeconds(3);
        Instantiate(DestroyAnim, transform.position, transform.rotation);
        Destroy(joint);
        Destroy(gameObject);
    }
}
