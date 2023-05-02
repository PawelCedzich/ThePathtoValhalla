//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;

//public class ChasePlayer : MonoBehaviour
//{
//    public NavMeshAgent agent;
//    public float range;
//    public Transform centrePoint;
//    public float playerDetectionRange;
//    public int stopTime;
//    public float NPCSpeed;
//    public float attackDistance;
//    public float attackCooldown;
//    public int minDamage;
//    public int maxDamage;
//    public Transform playerTransform;

//    private bool isWalking;
//    private bool isRunning;
//    private bool isAttacking;
//    private bool isReturning;
//    private Vector3 returnTarget;
//    private float attackTimer;

//    void Start()
//    {
//        agent = GetComponent<NavMeshAgent>();
//        if (agent.transform.position == new Vector3(0, 0, 0))
//        {
//            agent.transform.position = centrePoint.transform.position;
//        }

//        isWalking = false;
//        isRunning = false;
//        isAttacking = false;
//        isReturning = false;
//    }

//    IEnumerator wait(Animator animator)
//    {
//        agent.isStopped = true;
//        animator.SetBool("isWalking", false);
//        animator.SetBool("isRunning", false);
//        yield return new WaitForSeconds(stopTime);
//        agent.isStopped = false;
//        isWalking = true; // ustawienie isWalking na true po zakoñczeniu coroutine
//    }

//    void Update()
//    {
//        Animator animator = GetComponent<Animator>();

//        if (!isAttacking && !isReturning)
//        {
//            Collider[] colliders = Physics.OverlapSphere(transform.position, playerDetectionRange);
//            foreach (Collider collider in colliders)
//            {
//                if (collider.tag == "Player")
//                {
//                    agent.isStopped = false;
//                    StopCoroutine(wait(animator));
//                    fleeing = false;
//                    isWalking = false;
//                    isRunning = true;
//                    isAttacking = false;

//                    // Ustaw pozycjê gracza jako cel nawigacji
//                    agent.SetDestination(playerTransform.position);
//                    float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

//                    // SprawdŸ czy NPC jest wystarczaj¹co blisko gracza, aby zaatakowaæ
//                    if (distanceToPlayer <= attackDistance)
//                    {
//                        isAttacking = true;
//                        isRunning = false;
//                    }
//                }
//            }

//            if (!isAttacking && agent.remainingDistance <= agent.stoppingDistance)
//            {
//                Vector3 point;
//                if (RandomPoint(centrePoint.position, range, out point))
//                {
//                    Debug.DrawRay(point, Vector3.up, Color.blue, 1.0f);
//                    agent.speed = NPCSpeed;
//                    isWalking = false; // ustawienie isWalking na false przed coroutine
//                    isRunning = false;
//                    StartCoroutine(wait(animator));
//                    agent.SetDestination(point);
//                }
//            }
//        }
//        else if (isAttacking)
//        {
//            agent.isStopped = true;
//            transform.LookAt(playerTransform);

//            // Atakuj gracza co okreœlony czas
//            attackTimer += Time.deltaTime;
//            if (attackTimer >= attackCooldown)
//            {
//                isAttacking = false;
//                isRunning = true;
//                attackTimer = 0f;

//                // Zadaj losowe obra¿enia graczu
//                int damage = Random.Range(minDamage, maxDamage + 1);
//                playerTransform.GetComponent<PlayerHealth>().TakeDamage(damage);
//            }
//        }
//        else if (isReturning)
//        {
//            agent.SetDestination(returnTarget);
//            if (agent.remainingDistance <= agent.stoppingDistance)

//            {
//                agent.speed = NPCSpeed / 2;
//                isReturning = false;
//                isWalking = false;
//                isRunning = false;
//            }

//            animator.SetBool("isWalking", isWalking);
//            animator.SetBool("isRunning", isRunning);
//        }

//        void InflictDamage()
//        {
//            if (Time.time > lastAttackTime + attackInterval)
//            {
//                playerHealth.TakeDamage(Random.Range(5, 30));
//                lastAttackTime = Time.time;
//            }
//        }

//        void OnTriggerEnter(Collider other)
//        {
//            if (other.gameObject.tag == "Player")
//            {
//                playerInRange = true;
//            }
//        }

//        void OnTriggerExit(Collider other)
//        {
//            if (other.gameObject.tag == "Player")
//            {
//                playerInRange = false;
//            }
//        }
//    }
