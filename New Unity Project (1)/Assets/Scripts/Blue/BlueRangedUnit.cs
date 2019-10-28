using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueRangedUnit : UnitsStats
{
    private Vector3 Target;
    private Vector2 TargetDirection;
    private float xDif;
    private float yDif;
    private float speed;
    
    
    public int currentHealth { get; private set; }


   


    private void Awake()
    {
        currentHealth = maxHealth;
    }
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.002f; //any higher and they fly around the map
       
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    private void Move()
    {
        if (GameObject.FindGameObjectWithTag("RedMeleeUnit") == true)//will prioritize looking for unit with this tag and move towards it then go for buildings
        {
            Target = GameObject.FindGameObjectWithTag("RedMeleeUnit").transform.position.normalized;


            xDif = Target.x - transform.position.x;
            yDif = Target.x - transform.position.y;

            TargetDirection = new Vector2(xDif, yDif);
            transform.Translate(TargetDirection * speed);
        }
        else if (GameObject.FindGameObjectWithTag("RedMeleeUnit") != true)
        {
            Target = GameObject.FindGameObjectWithTag("RedRangedUnit").transform.position.normalized;


            xDif = Target.x - transform.position.x;
            yDif = Target.x - transform.position.y;

            TargetDirection = new Vector2(xDif, yDif);
            transform.Translate(TargetDirection * speed);
        }
        else
        {
            Target = GameObject.FindGameObjectWithTag("WizardUnit").transform.position.normalized;


            xDif = Target.x - transform.position.x;
            yDif = Target.x - transform.position.y;

            TargetDirection = new Vector2(xDif, yDif);
            transform.Translate(TargetDirection * speed);
        }

        if (GameObject.FindGameObjectWithTag("WizardUnit") != true) // if no unit can be found it will go for buildings
        {
            Target = GameObject.FindGameObjectWithTag("RedBuilding").transform.position.normalized;


            xDif = Target.x - transform.position.x;
            yDif = Target.x - transform.position.y;

            TargetDirection = new Vector2(xDif, yDif);
            transform.Translate(TargetDirection * speed);
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RedMeleeUnit")// if collided with take damage
        {
            TakeDamage(10);


        }
        else if (collision.gameObject.tag == "RedRangedUnit")
        {
            TakeDamage(10);
        }
        else if (collision.gameObject.tag == "WizardUnit")
        {
           TakeDamage(10);
        }

        
    }

        
    public override void Die()
    {

        base.Die();
        Destroy(gameObject);
    }


}
