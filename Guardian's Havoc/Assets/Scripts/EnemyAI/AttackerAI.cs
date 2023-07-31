using UnityEngine;
using UnityEngine.AI;

public class AttackerAI : MonoBehaviour
{
    [SerializeField] private GameObject attackTarget;

    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        NavigateToTower();
    }

    private void NavigateToTower()
    {
        agent.SetDestination(attackTarget.transform.position);
    }
}
