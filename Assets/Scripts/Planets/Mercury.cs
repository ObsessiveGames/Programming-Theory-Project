using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Mercury : Planet
{
    public Mercury(string planetName) : base(planetName)
    {

    }

    public override float GetHuman()
    {
        return 0;
    }
}