using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;
    public static PlayerHealthController instance;
    
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10f);
        }
    }

    public void TakeDamage(float damageToTake)
    {
        currentHealth -= damageToTake;

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }



}
