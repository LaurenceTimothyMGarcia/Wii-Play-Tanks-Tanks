using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyRotation : MonoBehaviour
{
   public Transform player;
   public GameObject bottomTank;

      void Start()
      {
         player = GameObject.FindWithTag("Player").transform;
      }

      // Update is called once per frame
      void Update()
      {
         transform.LookAt(player.position);
      }
}
