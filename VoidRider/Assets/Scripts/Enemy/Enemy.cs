using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public ParticleSystem DestroyAnim;

    public float HP;
    public float Damage;

    public abstract void GetDamage();
}
