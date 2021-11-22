using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public float delay = 10f;
    public float radius = 2f;

    float countdown;
    bool hasExploded = false;

    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
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

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            Explode();
        }
    }

    void Explode()
    {
        //show effect

        Collider[] colliderMet = Physics.OverlapSphere(transform.position, radius);

        foreach(Collider collider in colliderMet)
        {
            if (collider.gameObject.CompareTag("Breakable") || collider.gameObject.CompareTag("Bullet") || collider.gameObject.CompareTag("Enemy") || collider.gameObject.CompareTag("Player"))
            {
                Destroy(collider.gameObject);
            }
        }
        //get nearby objects
        //delete them

        Destroy(gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
