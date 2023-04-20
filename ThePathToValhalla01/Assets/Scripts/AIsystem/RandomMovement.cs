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

    private bool fleeing;
    private Vector3 fleeTarget;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        fleeing = false;
    }

    void Update()
    {
        if (!fleeing)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                Vector3 point;
                if (RandomPoint(centrePoint.position, range, out point))
                {
                    Debug.DrawRay(point, Vector3.up, Color.blue, 1.0f);
                    agent.SetDestination(point);
                    //Debug.Log("Chilled AI - " + point);
                }
            }

            Collider[] colliders = Physics.OverlapSphere(transform.position, playerDetectionRange);
            foreach (Collider collider in colliders)
            {
                if (collider.tag == "Player")
                {
                    Vector3 direction = transform.position - collider.transform.position;
                    direction.y = 0f;
                    fleeTarget = transform.position + direction.normalized * range * 5;
                    fleeing = true;
                }
            }
        }
        else
        {
            //Debug.Log("Fucked AI - " + fleeTarget);
            agent.SetDestination(fleeTarget);
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                fleeing = false;
            }
        }
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