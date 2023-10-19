using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float hp;
    [SerializeField] public HpBar hpBar;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EnemyBullet")
        {
            BulletToUse damage = other.GetComponent<BulletToUse>();
            hp -= damage.Damage;
        }
        if(hp <=0)
        {
            SceneManager.LoadScene("Play2");
        }
    }

    private void Update()
    {
        hpBar.hp_bar = hp;
    }
}