using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyRotation : MonoBehaviour
{
   public GameObject firePoint;
   public GameObject bullet;
   public GameObject bottomTank;

   public float fireRate;
   private float nextFireTime;

    // Update is called once per frame
    void Update()
    {
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDist = 0.0f;

        
    }
}
