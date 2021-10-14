using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float bulletSpeed;
    public int ricochets;
    Vector3 movementDir;
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpeed);
        
        
        //Destroy(gameObject, 3f);
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("Block") && ricochets > 0)
        {
            Vector3 wallNormal = coll.contacts[0].normal;
            movementDir = Vector3.Reflect(rb.velocity, wallNormal).normalized;

            rb.velocity = movementDir * bulletSpeed;

            ricochets--;
        }

        if (coll.gameObject.CompareTag("Block") && ricochets <= 0)
        {
            Destroy(gameObject, 0f);
        }
    }
}
