using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Mars : Planet
{
    public Mars(string planetName) : base(planetName)
    {

    }

    public override float GetHuman()
    {
        return 20;
    }
}