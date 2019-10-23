using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeUnit : Unit
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public MeleeUnit(int x, int y, string faction) : base(x, y, 200, 1, 20, 1, faction, '#', "Swordsman") { }

    public MeleeUnit(string values) : base(values) { }

     //*/
}
