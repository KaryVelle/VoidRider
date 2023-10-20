using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageControl : MonoBehaviour
{
   public GameObject imgWarn;
   public AudioSource gotHitSound;
   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("EnemyBullet"))
      {
         imgWarn.SetActive(true);
         StartCoroutine(ImgOff());
         gotHitSound.Play();
      }
   }

   private IEnumerator ImgOff()
   {
      
      yield return new WaitForSeconds(2);
      imgWarn.SetActive(false);
   }
}
