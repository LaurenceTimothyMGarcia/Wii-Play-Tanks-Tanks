using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopBehavior : MonoBehaviour
{
    public GameObject firePoint;
    public GameObject bullet;

    public float fireRate;
    private float nextFireTime;
    //public int bulletLimit;

    // Update is called once per frame
    void Update()
    {
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDist = 0.0f;

        //ROTATION
        if(playerPlane.Raycast(ray, out hitDist))
        {
            Vector3 targetPoint = ray.GetPoint(hitDist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            targetRotation.x = 0;
            targetRotation.z = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 100f * Time.deltaTime);
        }
        //SHOOTING
        int numBullets = GameObject.FindGameObjectsWithTag("Bullet").Length; //counts number of bullets on screen

        if(Input.GetMouseButtonDown(0) && Time.time >= nextFireTime && numBullets <= 5) //&& numBullets < bulletLimit)
        {
            nextFireTime = Time.time + 1f/fireRate;
            Shoot();
        }
    }

    void Shoot(){
        Instantiate(bullet.transform, firePoint.transform.position, firePoint.transform.rotation);
    }
}
