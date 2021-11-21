using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent enemy;

    Vector3 velocity = Vector3.zero;

    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        ChasePlayer();
        //should create ray between player and enemy
    }

    private void ChasePlayer()
    {
        enemy.SetDestination(Player.position);
        //Debug.Log(enemy.SetDestination(Player.position));
        transform.position = Vector3.SmoothDamp(transform.position, enemy.nextPosition, ref velocity, 0.1f);
    }

    private void AttackPlayer()
    {

    }
}
