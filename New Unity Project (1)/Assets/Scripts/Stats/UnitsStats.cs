
using UnityEngine;

public class UnitsStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currrentHealth { get; private set; }

    public Stats damage;

    private void Awake()
    {
        currrentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currrentHealth -= damage;

        if(currrentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        //die method here
    }
}
