using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;

    void Start()
    {

    }

    void Update()
    {

    }

    public void TakeDamage( float amount )
    {
        
        currentHealth = currentHealth - amount;
        if (!IsAlive())
        {
            currentHealth = 0;
            Die();
        }

    }
    public void Heal ( float amount)
    {
        currentHealth = currentHealth + amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
    public void Die()
    {
        // Get the Death component attached to this GameObject
        Death death = GetComponent<Death>();
        // If there is a Death component, call its Die method
        if (death != null)
        {
            death.Die();
        }
    }
    public bool IsAlive()
    {
        if (currentHealth > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class DamageData
{
    public int damageDone;
    public Controller damageDealer;
    public string damageType;
    public AudioClip damageSound;
} 