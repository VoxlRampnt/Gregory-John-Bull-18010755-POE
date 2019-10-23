﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBuilding : Building
{
   /* // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public enum ResourceType
    {
        WOOD,
        FOOD,
        ROCK,
        GOLD
    }

   
    
        private ResourceType type;
        private int generatedPerRound;
        private int generated;
        private int pool;

        public ResourceBuilding(int x, int y, string faction) : base(x, y, 100, faction, '^')
        {
            generatedPerRound = GameEngine.random.Next(1, 6);
            generated = 0;
            pool = GameEngine.random.Next(100, 200);
            type = (ResourceType)GameEngine.random.Next(0, 4);
        }

        public ResourceBuilding(string values)
        {
            string[] parameters = values.Split(',');

            x = int.Parse(parameters[1]);
            y = int.Parse(parameters[2]);
            health = int.Parse(parameters[3]);
            maxHealth = int.Parse(parameters[4]);
            type = (ResourceType)int.Parse(parameters[5]);
            generatedPerRound = int.Parse(parameters[6]);
            generated = int.Parse(parameters[7]);
            pool = int.Parse(parameters[8]);
            faction = parameters[9];
            symbol = parameters[10][0];
            isDestroyed = parameters[11] == "True" ? true : false;
        }

        public int Generated
        {
            get { return generated; }
            set { generated = value; }
        }

        public int Pool
        {
            get { return pool; }
            set { pool = value; }
        }

        public override void Destroy()
        {
            isDestroyed = true;
            generated = 0;
            symbol = '_';
        }

        public override string Save()
        {
            return string.Format($"Resource,{x},{y},{health},{maxHealth},{(int)type},{generatedPerRound},{generated},{pool},{faction},{symbol},{isDestroyed}");
        }

        public void GenerateResources()
        {
            if (isDestroyed)
                return;

            if (pool > 0)
            {
                int resourcesGenerated = Math.Min(pool, generatedPerRound);
                generated += resourcesGenerated;
                pool -= resourcesGenerated;
            }
        }

        string GetResourceName()
        {
            return new string[] { "Wood", "Food", "Rock", "Gold" }[(int)type];
        }

        public override string ToString()
        {
            return
                "------------------------------------------" + Environment.NewLine +
                "Resource Building (" + symbol + "/" + faction[0] + ")" + Environment.NewLine +
                "------------------------------------------" + Environment.NewLine +
                GetResourceName() + ": " + generated + Environment.NewLine +
                "Pool: " + pool + Environment.NewLine +
                base.ToString() + Environment.NewLine;
        }
    */
}
