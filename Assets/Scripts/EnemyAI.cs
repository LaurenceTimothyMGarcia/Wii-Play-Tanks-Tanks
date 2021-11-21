using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent enemy;

    public GameObject firePoint;
    public GameObject bullet;

    public float fireRate;
    private float nextFireTime = 1;
    public int bulletLimit;

    public bool canMove = true;

    Vector3 velocity = Vector3.zero;

    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)//checks if tanks can move or not
        {
            ChasePlayer();
        }
        
        AttackPlayer();
    }

    private void ChasePlayer()
    {
        try { enemy.SetDestination(Player.position); }
        catch { }
        //Debug.Log(enemy.SetDestination(Player.position));
        transform.position = Vector3.SmoothDamp(transform.position, enemy.nextPosition, ref velocity, 0.1f);
    }

    private void AttackPlayer()
    {
        int numBullets = GameObject.FindGameObjectsWithTag("Bullet").Length;

        if (Time.time >= nextFireTime && numBullets <= bulletLimit)
        {
            nextFireTime = Time.time + 1f/fireRate;
            Shoot();
            FindObjectOfType<AudioManager>().Play("TankShoot");
        }
    }

    void Shoot()
    {
        Instantiate(bullet.transform, firePoint.transform.position, firePoint.transform.rotation);
    }
}
