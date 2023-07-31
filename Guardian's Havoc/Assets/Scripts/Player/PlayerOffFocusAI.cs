using System;
using UnityEngine;
using UnityEngine.AI;

public class PlayerOffFocusAI : MonoBehaviour
{
    [SerializeField] private NavMeshAgent playerAgent;
    [SerializeField] private float destinationOffset = 0.2f;
    [SerializeField] private Transform[] waypoints;

    private Transform tf;
    private bool isSelected;
    private bool isNavigating = false;

    void Start()
    {
        tf = GetComponent<Transform>();
    }

    void Update()
    {
        if (!isSelected)
        {
            playerAgent.enabled = true;
            if (!isNavigating)
            {
                playerAgent.SetDestination(waypoints[0].position);
                isNavigating = true;
            }
            else
            {
                NavigateWaypoints();
            }
        }
        else { playerAgent.enabled = false; }
    }

    private void NavigateWaypoints()
    {
        if (Vector3.Distance(tf.position, waypoints[0].position) < destinationOffset)
        {
            playerAgent.SetDestination(waypoints[1].position);
        }

        if (Vector3.Distance(tf.position, waypoints[1].position) < destinationOffset)
        {
            playerAgent.SetDestination(waypoints[0].position);
        }
    }

    public void SetIsSelected(bool value)
    {
        isSelected = value;
    }

    public void SetIsNavigating(bool value)
    {
        isNavigating = value;
    }
}
