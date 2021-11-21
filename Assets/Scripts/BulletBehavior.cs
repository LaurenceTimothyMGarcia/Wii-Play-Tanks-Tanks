using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BulletBehavior : MonoBehaviour
{
    public float bulletSpeed;
    public int ricochets;
    Vector3 lastVelocity;
    Vector3 movementDir;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);
        
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Time.deltaTime * bulletSpeed + .05f)) {
            if(hit.collider.gameObject.CompareTag("Breakable") || hit.collider.gameObject.CompareTag("Bullet") || hit.collider.gameObject.CompareTag("Enemy") || hit.collider.gameObject.CompareTag("Player"))
            {
                FindObjectOfType<AudioManager>().Play("BulletCollide");
                Destroy(hit.collider.gameObject);
                ricochets = 0;
            }
            if(ricochets == 0) {
                Destroy(gameObject);
                return;
            }
            FindObjectOfType<AudioManager>().Play("BulletReflect");
            Vector3 reflect = Vector3.Reflect(ray.direction, hit.normal);
            float rot = 90 - Mathf.Atan2(reflect.z, reflect.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, rot, 0);
            ricochets--;
        }

        //Destroy(gameObject, 3f);
    }

    //This entire on collision portion does not work
    //Bullets still ricochets without it
    /*void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("Breakable"))
        {
            Debug.Log("Hit");
            Destroy(coll.gameObject, 0f);
            Destroy(gameObject, 0f);
        }

        if (coll.gameObject.CompareTag("Block") && ricochets > 0)
        {
            Debug.Log(ricochets);
            
            bulletSpeed = lastVelocity.magnitude;
            movementDir = Vector3.Reflect(lastVelocity.normalized, coll.contacts[0].normal);

            //Vector3 wallNormal = coll.contacts[0].normal;
            //movementDir = Vector3.Reflect(rb.velocity, wallNormal).normalized;

            //rb.velocity = movementDir * bulletSpeed;

            ricochets--;
        }

        if (coll.gameObject.CompareTag("Block") && ricochets <= 0)
        {
            Destroy(gameObject, 0f);
        }
    }*/
}
