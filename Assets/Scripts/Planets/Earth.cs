using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is the derived class which is also known as the child class.
// INHERITANCE
public class Earth : Planet
{
    public Earth(string planetName) : base(planetName)
    {
        DoesPlanetHaveHumans(planetName);
    }

    public override float GetHuman()
    {
        return 1;
    }

    // ENCAPSULATION
    private void DoesPlanetHaveHumans(string planetName)
    {
        Debug.Log($"This is fired straight after Planet has been created with Earth");
        Debug.Log($"{planetName} has Humans on it");
        Debug.Log("---------------");
    }
}
