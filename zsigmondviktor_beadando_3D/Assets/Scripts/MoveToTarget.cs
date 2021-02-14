using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour
{
    //public Transform Target;
    public Transform[] points;
    private NavMeshAgent agent;
    private int destPoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<NavMeshAgent>().destination = Target.position;
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
    }

    void GotoNextPoint()
    {
        if (points.Length == 0)
        {
            return;
        }

        agent.destination = points[destPoint].position;

        destPoint = (destPoint + 1) % points.Length;
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GotoNextPoint();
        }
    }
}
