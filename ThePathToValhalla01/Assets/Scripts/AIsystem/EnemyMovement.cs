using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public NavMeshAgent agent;
    public float range;
    public Transform centrePoint;
    public float playerDetectionRange;
    public int stopTime;
    public float NPCSpeed;
    public float maxDistanceFromCenter;
    public float attackRange;
    public int damagePerHit;
    public int attackSpeed;
    public float chanceOfMiss;
    public float timeToDMG;

    private GameObject player;
    private PlayerStats playerStats;
    private bool isWalking;
    private bool isRunning;
    private bool isAttacking = false;
    private bool chasing;
    private Vector3 centerPosition;
    private float lastAttackTime;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerStats = player.GetComponentInChildren<PlayerStats>();

        centerPosition = centrePoint.position;
        isWalking = false;
        isRunning = false;
        chasing = false;
        lastAttackTime = Time.time;
    }

    IEnumerator wait(Animator animator)
    {
        agent.isStopped = true;
        animator.SetBool("isWalking", false);
        animator.SetBool("isRunning", false);
        yield return new WaitForSeconds(stopTime);
        agent.isStopped = false;
        isWalking = true;
    }

    IEnumerator dealDamage(float time, int damage)
    {
        yield return new WaitForSeconds(time);
        playerStats.TakeDamage(damage);
    }

    void Update()
    {
        Animator animator = GetComponent<Animator>();

        if (!chasing)
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, playerDetectionRange);
            foreach (Collider collider in colliders)
            {
                if (collider.gameObject == player)
                {
                    agent.isStopped = false;
                    StopCoroutine(wait(animator));
                    chasing = true;
                    agent.speed = NPCSpeed * 2;
                    isWalking = false;
                    isRunning = true;
                }
            }

            if (agent.remainingDistance <= agent.stoppingDistance && !agent.pathPending && !chasing)
            {
                Vector3 point;
                if (RandomPoint(transform.position, range, out point))
                {
                    agent.speed = NPCSpeed;
                    isWalking = false;
                    isRunning = false;
                    StartCoroutine(wait(animator));
                    agent.SetDestination(point);
                }
                else
                {
                    agent.speed = NPCSpeed;
                    isWalking = false;
                    isRunning = false;
                    StartCoroutine(wait(animator));
                    agent.SetDestination(centrePoint.position);
                }
            }
        }
        else
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
            if (distanceToPlayer <= attackRange && Time.time - lastAttackTime >= attackSpeed)
            {
                isWalking = false;
                isRunning = false;
                agent.isStopped = true;
                isAttacking = true;
                var hit = Random.Range(0.0f, 1.0f);
                if (hit > chanceOfMiss)
                {
                    StartCoroutine(dealDamage(timeToDMG, damagePerHit));
                }
                lastAttackTime = Time.time;
            }
            else
            {
                isRunning = true;
                isWalking = false;
                agent.isStopped = false;
                isAttacking = false;
            }

            agent.SetDestination(player.transform.position);
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                agent.speed = NPCSpeed / 2;
                chasing = false;
                isWalking = false;
                isRunning = false;
            }
        }

        if (Vector3.Distance(transform.position, centrePoint.position) > maxDistanceFromCenter)
        {
            agent.SetDestination(centrePoint.position);
            isWalking = false;
            isRunning = false;
            chasing = false;
            isAttacking = false;
            StartCoroutine(wait(animator));
        }

        animator.SetBool("setAttack", isAttacking);
        animator.SetBool("isWalking", isWalking);
        animator.SetBool("isRunning", isRunning);
    }

    bool RandomPoint(Vector3 center, float range, out Vector3 result)
    {
        Vector3 randomPoint = center + Random.insideUnitSphere * range;
        NavMeshHit hit;
        if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas))
        {
            result = hit.position;
            return true;
        }

        result = Vector3.zero;
        return false;
    }
}
