using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    public float delay = 10f;
    public float radius = 3f;
    public GameObject explosion;

    float countdown;
    bool hasExploded = false;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("MinePlant");
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
        if (countdown <= 9f)
        {
            Explode();
        }
    }

    void Explode()
    {
        //show effect

        Collider[] colliderMet = Physics.OverlapSphere(transform.position, radius);
        FindObjectOfType<AudioManager>().Play("MineBlowUp");
        AddExplosion();

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

    void AddExplosion()
    {
        GameObject explode = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(explode, 1f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
