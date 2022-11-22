using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Venus : Planet
{
    public Venus(string planetName) : base(planetName)
    {

    }

    public override float GetHuman()
    {
        return 220;
    }
}