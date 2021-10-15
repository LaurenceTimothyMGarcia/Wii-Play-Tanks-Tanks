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
        lastVelocity = rb.velocity;
        
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
