
using UnityEngine;

public class UnitStas : MonoBehaviour
{
    
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public Stat damage;

    
    private void Start()
    {
        
    }


    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(transform.name + "takes" + damage + "damage");

        /*if(currentHealth <= 25)
        {
            RunAway();
        }*/

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        //die method here will remove/respawn
    }
}
