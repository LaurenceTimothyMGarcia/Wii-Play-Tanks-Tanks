using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent enemy;



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
    }

    private void AttackPlayer()
    {

    }
}
