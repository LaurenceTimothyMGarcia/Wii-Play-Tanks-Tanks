using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyRotation : MonoBehaviour
{
   public Transform player;
   public GameObject firePoint;
   public GameObject bullet;
   public GameObject bottomTank;

   public float fireRate;
   private float nextFireTime;

      // Update is called once per frame
      void Update()
      {
         transform.LookAt(player);
      }
}
