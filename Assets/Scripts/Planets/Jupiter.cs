using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Jupiter : Planet
{
    public Jupiter(string planetName) : base(planetName)
    {

    }

    public override float GetHuman()
    {
        return 0;
    }
}