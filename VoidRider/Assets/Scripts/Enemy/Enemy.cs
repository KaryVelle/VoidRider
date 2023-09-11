using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public Transform shootPos1;
    public ParticleSystem DestroyAnim;
    public GameObject BalaPrefab;
    public BulletToUse Bala;
    public float Delay;
    public bool Fire;


    public float HP;
    public float Damage;

}
