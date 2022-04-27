using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float bulletSpeed;
    public int ricochets;

    public static bool didReflect;  //Checks if bullet reflected or not

    Vector3 lastVelocity;
    Vector3 movementDir;

    // Update is called once per frame
    void Update()
    {
        //Bullet moves to this speed
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);
        
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Time.deltaTime * bulletSpeed + .05f)) {
            //This initial if statement is to check if the bullet can destroy the object
            if(hit.collider.gameObject.CompareTag("Breakable") || hit.collider.gameObject.CompareTag("Bullet") || hit.collider.gameObject.CompareTag("Enemy") || hit.collider.gameObject.CompareTag("Player"))
            {
                FindObjectOfType<AudioManager>().Play("BulletCollide");
                Destroy(hit.collider.gameObject);

                //Adds score to player, checks for reflect kill
                if(didReflect && hit.collider.gameObject.CompareTag("Enemy"))
                {
                    Score.score += 200;
                    Debug.Log("Refelct and kill");
                }
                else if(hit.collider.gameObject.CompareTag("Enemy"))
                {
                    Score.score += 100;
                    Debug.Log("only kill");
                }
                ricochets = 0;
            }

            //Blows up mine
            if (hit.collider.gameObject.CompareTag("Mine"))
            {
                FindObjectOfType<AudioManager>().Play("BulletCollide");
                //Destroy(hit.collider.gameObject);
                ricochets = 0;
            }

            if(ricochets == 0) {
                didReflect = false;
                Destroy(gameObject);
                return;
            }

            //Actual reflect
            FindObjectOfType<AudioManager>().Play("BulletReflect");
            Vector3 reflect = Vector3.Reflect(ray.direction, hit.normal);
            float rot = 90 - Mathf.Atan2(reflect.z, reflect.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, rot, 0);
            ricochets--;
            didReflect = true;
        }

        //Destroy(gameObject, 3f);
    }
}
