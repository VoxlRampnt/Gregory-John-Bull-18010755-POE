using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueRangedUnit : MonoBehaviour
{
    private Vector3 Target;
    private Vector2 TargetDirection;
    private float xDif;
    private float yDif;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.002f; //any higher and they fly around the map
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("RedUnit") == true)//will prioritize looking for unit with this tag and move towards it then go for buildings
        {
            Target = GameObject.FindGameObjectWithTag("RedUnit").transform.position;


            xDif = Target.x - transform.position.x;
            yDif = Target.x - transform.position.y;

            TargetDirection = new Vector2(xDif, yDif);
            transform.Translate(TargetDirection * speed);
        }
        else if (GameObject.FindGameObjectWithTag("RedUnit") != true)
        {
            Target = GameObject.FindGameObjectWithTag("WizardUnit").transform.position;


            xDif = Target.x - transform.position.x;
            yDif = Target.x - transform.position.y;

            TargetDirection = new Vector2(xDif, yDif);
            transform.Translate(TargetDirection * speed);
        }
        else
        {
            Target = GameObject.FindGameObjectWithTag("RedBuilding").transform.position;


            xDif = Target.x - transform.position.x;
            yDif = Target.x - transform.position.y;

            TargetDirection = new Vector2(xDif, yDif);
            transform.Translate(TargetDirection * speed);
        }
    }

    
    
}
