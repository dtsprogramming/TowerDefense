using UnityEngine;
using UnityEngine.UI;

public class TowerHealth : MonoBehaviour
{
    [Header("Tower Health")]
    [SerializeField] private float totalHealth = 100;
    [SerializeField] private float currentHealth = 0;
    [SerializeField] private Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = totalHealth;
    }

    public void ReduceHealth(float damage)
    {
        currentHealth -= damage;
        SetSliderValue();
    }

    private void SetSliderValue()
    {
        healthSlider.value = currentHealth/100;
    }
}
