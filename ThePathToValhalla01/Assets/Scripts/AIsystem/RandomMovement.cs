using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomMovement : MonoBehaviour
{
    public NavMeshAgent agent;
    public float range;
    public Transform centrePoint;
    public float playerDetectionRange;
    public int stopTime;
    public float NPCSpeed;

    private bool isWalking;
    private bool isRunning;
    private bool fleeing;
    private Vector3 fleeTarget;
    private float lastFleeTarget;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if(agent.transform.position == new Vector3(0, 0, 0))
        {
            agent.transform.position = centrePoint.transform.position;
        }
       
        isWalking = false;
        isRunning = false;
        fleeing = false;
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

    void Update()
    {
        Animator animator = GetComponent<Animator>();

        if (!fleeing)
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, playerDetectionRange);
            foreach (Collider collider in colliders)
            {
                if (collider.tag == "Player")
                {
                    agent.isStopped = false;
                    StopCoroutine(wait(animator));
                    Vector3 direction = transform.position - collider.transform.position;
                    direction.y = 0f;
                    fleeTarget = transform.position + direction.normalized * range * 5;
                    fleeing = true;
                    agent.speed = NPCSpeed * 2;
                    isWalking = false;
                    isRunning = true;
                }
            }

            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                Vector3 point;
                if (RandomPoint(centrePoint.position, range, out point))
                {
                    Debug.DrawRay(point, Vector3.up, Color.blue, 1.0f);
                    agent.speed = NPCSpeed;
                    isWalking = false;
                    isRunning = false;
                    StartCoroutine(wait(animator));
                    agent.SetDestination(point);
                }
            }
        }
        else
        {
            agent.SetDestination(fleeTarget);
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                agent.speed = NPCSpeed/2;
                fleeing = false;
                isWalking = false;
                isRunning = false;
            }

            if (Time.time - lastFleeTarget >= 2f)
            {
                Collider[] colliders = Physics.OverlapSphere(transform.position, playerDetectionRange);
                foreach (Collider collider in colliders)
                {
                    if (collider.tag == "Player")
                    {
                        Vector3 direction = transform.position - collider.transform.position;
                        direction.y = 0f;
                        fleeTarget = transform.position + direction.normalized * range * 5;
                    }
                }
                lastFleeTarget = Time.time;
            }
            
        }
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