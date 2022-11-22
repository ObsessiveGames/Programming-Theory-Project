using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Saturn : Planet
{
    public Saturn(string planetName) : base(planetName)
    {

    }

    public override float GetHuman()
    {
        return 11;
    }
}