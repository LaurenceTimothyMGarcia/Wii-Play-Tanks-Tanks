using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public GameObject bullet;

    public float timeBetweenShooting, spread, timeBetweenShots;
    public int magazineSize, bulletsPerTap;
    public bool allowButtonHold;


    int bulletsLeft, bulletShoot;
    bool shooting, readyToSchoot, reloading;

    public Camera fpsCam;
    public Transform attackPoint;

    //graphics
    public GameObject muzzuleFlash;
    

    public bool allowInvoke;
    private void Awake()
    {
        bulletsLeft = magazineSize;
        readyToSchoot = true;
    }

    private void Update()
    {
        myInput();
    }

    private void myInput()
    {
        if (allowButtonHold) shooting = Input.GetKey(KeyCode.Mouse0);
        else shooting = Input.GetKeyDown(KeyCode.Mouse0);

        //reloading
        if (readyToSchoot && shooting && !reloading && bulletsLeft <= 0)
        {
            Reload();
        }

        //shooting
        if (readyToSchoot && shooting && !reloading && bulletsLeft > 0)
        {
            bulletShoot = 0;

            Shoot();
        }
    }

    private void Shoot()
    {
        readyToSchoot = false;

        Ray ray = fpsCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
        {
            targetPoint = hit.point;

        }

        else
        {
            targetPoint = ray.GetPoint(75);
        }

        Vector3 direction = targetPoint - attackPoint.position;

        //spawed bullets are stored here
        GameObject currentBullet = Instantiate(bullet, attackPoint.position, Quaternion.identity);

        if (muzzuleFlash != null)
        {
            Instantiate(mazzuleFlash, attackPoint.position, Quaternion);
        }
        bulletsLeft--;
        bulletShoot++;
        if (allowInvoke)
        {
            Invoke("ResetShot", timeBetweenShooting);
            allowInvoke = false;
        }
    }




    private void ResetShot()
    {
        readyToSchoot = true;
        allowInvoke = true;

    }

    private void Reload()
    {
        reloading = true;
        Invoke("ReloadFinished".Insert reloadTime);
    }

    private void ReloadFinished()
    {
        bulletsLeft = magazineSize;
        reloading = false;
    }
}

















/* previous code

    public LayerMask collisionMask;
    public float bulletSpeed;
    public int ricochets;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);


        //Destroy(gameObject, 3f);

        //Ricocheting code, having difficulty, I think the bullets themselves need to be an individual object so we can 
        //apply a collider? Right now its only going through the walls. 
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Time.deltaTime * bulletSpeed + .1f,collisionMask))
        {
            Vector3 reflectDirection = Vector3.Reflect(ray.direction, hit.normal);
            float rot = 90 - Mathf.Atan2(reflectDirection.z, reflectDirection.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, rot, 0);
        }

*/