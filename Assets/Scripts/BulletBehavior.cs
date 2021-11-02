using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BulletBehavior : MonoBehaviour
{
    public float bulletSpeed;
    public int ricochets;
    Vector3 lastVelocity;
    Vector3 movementDir;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(1f, 0, 1f);

        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);
        
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Time.deltaTime * bulletSpeed + .05f)) {
            if(ricochets == 0) {
                Destroy(gameObject);
            }
            Vector3 reflect = Vector3.Reflect(ray.direction, hit.normal);
            float rot = 90 - Mathf.Atan2(reflect.z, reflect.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, rot, 0);
            ricochets--;
        }

        //Destroy(gameObject, 3f);
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("Block") && ricochets > 0)
        {
            Debug.Log(ricochets);

            bulletSpeed = lastVelocity.magnitude;
            movementDir = Vector3.Reflect(lastVelocity.normalized, coll.contacts[0].normal);

            rb.velocity = movementDir * Mathf.Max(bulletSpeed, 1f);

            //Vector3 wallNormal = coll.contacts[0].normal;
            //movementDir = Vector3.Reflect(rb.velocity, wallNormal).normalized;

            //rb.velocity = movementDir * bulletSpeed;

            ricochets--;
        }

        if (coll.gameObject.CompareTag("Block") && ricochets <= 0)
        {
            Destroy(gameObject, 0f);
        }
    }
}
