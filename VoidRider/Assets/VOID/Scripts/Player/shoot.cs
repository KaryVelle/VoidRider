using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class shoot : MonoBehaviour
{

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private GameObject bulletPrefab2;
    [SerializeField] private Transform shootFrom1;
    [SerializeField] private Transform shootFrom2;
    
    [SerializeField] private Transform shootFromBack1;
    [SerializeField] private Transform shootFromBack2;
    [SerializeField] private float speed;
    public float shootMulti = 1f;
    
    private Rigidbody rb1;
    private Rigidbody rb2;
 
    public int destroyBulletTime1 = 10;
    public int destroyBulletTime2 = 10;
    public int destroyBulletTime3 = 10;

  

    public void Shoot1()
    {
        GameObject bullet1= Instantiate(bulletPrefab, shootFrom1.position, shootFrom1.rotation);
        rb1 = bullet1.GetComponent<Rigidbody>();
        rb1.AddForce(transform.forward * speed * shootMulti);
        Destroy(bullet1, destroyBulletTime3);
        
        GameObject bullet2= Instantiate(bulletPrefab, shootFrom2.position, shootFrom2.rotation);
        rb2 = bullet2.GetComponent<Rigidbody>();
        rb2.AddForce(transform.forward * speed * shootMulti);
        Destroy(bullet2, destroyBulletTime3);

        

    }
    
    public void Shoot2()
    {
        GameObject bullet1= Instantiate(bulletPrefab2, shootFrom1.position, shootFrom1.rotation);
        rb1 = bullet1.GetComponent<Rigidbody>();
        rb1.AddForce(transform.forward * speed * shootMulti);
        Destroy(bullet1, destroyBulletTime2);
        
        GameObject bullet2= Instantiate(bulletPrefab2, shootFrom2.position, shootFrom2.rotation);
        rb2 = bullet2.GetComponent<Rigidbody>();
        rb2.AddForce(transform.forward * speed * shootMulti);
        Destroy(bullet2, destroyBulletTime2);
        

    }
    
    public void Shoot3()
    {
        GameObject bullet1= Instantiate(bulletPrefab, shootFromBack1.position, shootFrom1.rotation);
        rb1 = bullet1.GetComponent<Rigidbody>();
        rb1.AddForce(transform.forward * speed * -1 * shootMulti);
        Destroy(bullet1, destroyBulletTime3);
        
        GameObject bullet2= Instantiate(bulletPrefab, shootFromBack2.position, shootFrom2.rotation);
        rb2 = bullet2.GetComponent<Rigidbody>();
        rb2.AddForce(transform.forward * speed * -1 * shootMulti);
        Destroy(bullet2, destroyBulletTime3);
        
    }
 
}
