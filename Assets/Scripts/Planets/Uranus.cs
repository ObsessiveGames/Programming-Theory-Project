using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Uranus : Planet
{
    public Uranus(string planetName) : base(planetName)
    {

    }

    public override float GetHuman()
    {
        return 5000;
    }
}