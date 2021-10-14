using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float bulletSpeed;
    public int ricochets;
    public Transform bulletTransform;

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
            //Destroy(gameObject, 0f);

            //Vector3 wallNormal = coll.contacts[0].normal;
            //bulletTransform = Vector3.Reflect(bulletTransform.position, wallNormal).normalize;

            //bulletTransform.velocity = bulletTransform * bulletSpeed;

            ricochets--;
        }

        if (coll.gameObject.CompareTag("Block") && ricochets <= 0)
        {
            Destroy(gameObject, 0f);
        }
    }
}
