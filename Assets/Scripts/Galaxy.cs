using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galaxy : MonoBehaviour
{
    private void Start()
    {
        FirstGalaxyPlanets firstGalaxy = new FirstGalaxyPlanets();
    }

    // POLYMORPHISM
    public class FirstGalaxyPlanets
    {
        public Planet[] planets;
        public FirstGalaxyPlanets()
        {
            planets = new Planet[8];
            planets[0] = new Earth("Earth");
            planets[1] = new Jupiter("Jupiter");
            planets[2] = new Mars("Mars");
            planets[3] = new Mercury("Mercury");
            planets[4] = new Neptune("Neptune");
            planets[5] = new Saturn("Saturn");
            planets[6] = new Uranus("Uranus");
            planets[7] = new Venus("Venus");
        
            // Can be used if there are any methods related in each of these classes.
            if (planets[0] is Earth)
            {
                Earth earth = planets[0] as Earth;
            }
            if (planets[1] is Jupiter)
            {
                Jupiter jupiter = planets[1] as Jupiter;
            }
            if (planets[2] is Mars)
            {
                Mars mars = planets[2] as Mars;
            }
            if (planets[3] is Mercury)
            {
                Mercury mercury = planets[3] as Mercury;
            }
            if (planets[4] is Neptune)
            {
                Neptune neptune = planets[4] as Neptune;
            }
            if (planets[5] is Saturn)
            {
                Saturn saturn = planets[5] as Saturn;
            }
            if (planets[6] is Uranus)
            {
                Uranus uranus = planets[6] as Uranus;
            }
            if (planets[7] is Venus)
            {
                Venus venus = planets[7] as Venus;
            }
        }
    }
}
