using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is the base class which is also known as the Parent class.
// ABSTRACTION
public abstract class Planet
{
    public string color;

    public Planet(string planetName)
    {
        Debug.Log($"{planetName} generated");
        if (GetHuman() > 0)
        {
            Debug.Log($"{planetName} has {GetHuman()} humans");
        }
        else
        {
            Debug.Log($"{planetName} has no humans");
        }

        Debug.Log("---------------");
    }

    // ABSTRACTION
    public abstract float GetHuman();

    public void IdentifyColor()
    {
        Debug.Log("The planets color in general is " + color);
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a planet");
    }
}
