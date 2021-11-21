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
        try
        {
            Vector3 targetPosition = new Vector3(player.position.x, this.transform.position.y, player.position.z);
            transform.LookAt(targetPosition);
        }
        catch { }
      }
}
