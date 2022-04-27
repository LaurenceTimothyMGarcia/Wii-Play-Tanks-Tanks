using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopBehavior : MonoBehaviour
{
    public GameObject firePoint;
    public GameObject bullet;
    public GameObject bottomTank;

    public float fireRate;
    private float nextFireTime;
    public int bulletLimit;

    // Update is called once per frame
    void Update()
    {
        Plane playerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = UnityEngine.Camera.main.ScreenPointToRay(Input.mousePosition);    //This is how the tank head follows and tracks the mouse rotation
        float hitDist = 0.0f;

        //Transform movement = transform.GetComponentInParent<Transform>;

        Transform movement = bottomTank.transform;

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
        if (!PauseMenu.isPaused && !LoseScreen.lost && !WinLevel.win)
        {
            int numBullets = GameObject.FindGameObjectsWithTag("Bullet").Length; //counts number of bullets on screen

            //Click mouse to shoot bullet
            if(Input.GetMouseButtonDown(0) && Time.time >= nextFireTime && numBullets <= bulletLimit)
            {
                nextFireTime = Time.time + 1f/fireRate;
                Shoot();
                FindObjectOfType<AudioManager>().Play("TankShoot");
            }
        }
    }


    //Creates bullet
    void Shoot(){
        Instantiate(bullet.transform, firePoint.transform.position, firePoint.transform.rotation);
    }
}
