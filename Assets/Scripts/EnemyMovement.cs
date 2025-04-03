using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Get the NavMeshAgent component attached to this GameObject
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.updateRotation = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Check if the player is assigned and update the destination
        if (player != null)
        {
            navMeshAgent.SetDestination(player.position);
        }        
    }
}
