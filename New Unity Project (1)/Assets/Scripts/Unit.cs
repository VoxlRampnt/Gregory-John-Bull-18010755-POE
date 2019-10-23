using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : Target
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    protected int speed;
    protected int attack;
    protected int attackRange;
    protected bool isAttacking = false;
    protected string name;

    

    public Unit(int x, int y, int health, int speed, int attack, int attackRange, string faction, string name)
    {

        this.health = health;
        maxHealth = health;
        this.speed = speed;
        this.attack = attack;
        this.attackRange = attackRange;
        this.name = name;

        this.x = x;
        this.y = y;
        this.faction = faction;
    }

    public Unit(string values)
    {
        string[] parameters = values.Split(',');

        X = int.Parse(parameters[1]);
        Y = int.Parse(parameters[2]);
        health = int.Parse(parameters[3]);
        maxHealth = int.Parse(parameters[4]);
        speed = int.Parse(parameters[5]);
        attack = int.Parse(parameters[6]);
        attackRange = int.Parse(parameters[7]);
        faction = parameters[8];
       
        name = parameters[10];
        isDestroyed = parameters[11] == "True" ? true : false;
    }

    


    public string Name
    {
        get { return name; }
    }

    public int Speed
    {
        get { return speed; }
    }

    //returns true if target was destroyed
    public virtual bool Attack(Target target)
    {
        isAttacking = true;
        target.Health -= attack;

        if (target.Health <= 0)
        {
            target.Health = 0;
            target.Destroy();
            return true;
        }

        return false;
    }

    public override void Destroy()
    {
        Health = 0;
        isDestroyed = true;
        isAttacking = false;
        
    }

    public float GetDistance(Target to)
    {
        float xDistance = to.X - X;
        float yDistance = to.Y - Y;

        return Mathf.Sqrt(xDistance * xDistance + yDistance * yDistance);
    }

    public virtual bool IsInRange(Target target)
    {
        return GetDistance(target) <= attackRange;
    }

    public virtual void Move(Target closestTarget)
    {
        int xDirection = closestTarget.X - X;
        int yDirection = closestTarget.Y - Y;

        if (Mathf.Abs(xDirection) > Mathf.Abs(yDirection))
        {
            x += Mathf.Sign(xDirection);
        }
        else
        {
            y += Mathf.Sign(yDirection);
        }
    }

    public virtual void RunAway()
    {
        int direction = random.Next(0, 4);
        if (direction == 0)
        {
            x += 1;
        }
        else if (direction == 1)
        {
            x -= 1;
        }
        else if (direction == 2)
        {
            y += 1;
        }
        else
        {
            y -= 1;
        }
    }

    public override string ToString()
    {
        return
            "------------------------------------------" + Environment.NewLine +
            name + " ("  + faction[0] + ")" + Environment.NewLine +
            "------------------------------------------" + Environment.NewLine +
            "Faction: " + faction + Environment.NewLine +
            "Position: " + x + ", " + y + Environment.NewLine +
            "Health: " + health + " / " + maxHealth + Environment.NewLine;
    }

    */
}
