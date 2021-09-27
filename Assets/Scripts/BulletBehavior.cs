using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
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


    }
}
