using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Neptune : Planet
{
    public Neptune(string planetName) : base(planetName)
    {

    }

    public override float GetHuman()
    {
        return 220;
    }
}