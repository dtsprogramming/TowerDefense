using UnityEngine;
using UnityEngine.AI;

public class AttackerAI : MonoBehaviour
{
    [SerializeField] private float offsetToTarget = 0.5f;
    [SerializeField] private Transform[] attackTargets;

    private NavMeshAgent agent;
    private Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(tf.position, attackTargets[0].position) > offsetToTarget)
        {
            NavigateToTower();
        }
    }

    private void NavigateToTower()
    {
        int randIndex = Random.Range(0, attackTargets.Length);
        
        agent.SetDestination(attackTargets[randIndex].transform.position);
    }
}
