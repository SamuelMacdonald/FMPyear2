using UnityEngine;
using UnityEngine.AI;

public class MovementZombie : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); 
        updateDestination();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target) < 1)
        {
            IlterateWaypointIndex();
            updateDestination();
        }
    }
    private void updateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    void IlterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
    }



}
