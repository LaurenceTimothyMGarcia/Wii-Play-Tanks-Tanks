using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public float timer = 10f;
    public float radius = 5f;
    public GameObject explosionEffect;

    float countdown;
    bool hasExploded = false;
    
    // Start is called before the first frame update
    void Start()
    {
        countdown = timer;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    void Explode()
    {
        //exploding effect will add later?
        //Instantiate(explosionEffect, transform.position, transform.rotation);

        //get nearby objects
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearbyObject in colliders)
        {
            if (nearbyObject.gameObject.CompareTag("Breakable") || 
                nearbyObject.gameObject.CompareTag("Bullet") || 
                nearbyObject.gameObject.CompareTag("Enemy") || 
                nearbyObject.gameObject.CompareTag("Player"))
            {
                Destroy(nearbyObject.gameObject);
            }
        }
        
        Destroy(gameObject);
    }
}
