using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private float damageValue = 10;
    [SerializeField] private TowerHealth tower;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Tower")
        {
            tower.ReduceHealth(damageValue);
        }
    }
}
