using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigPlanet : planet
{
    
   // SpaceShip ship;
    void Start()
    {
        time = 0.4f;
    //    ship = new SpaceShip();
        if (time > 0)
        {
            StartCoroutine(onTime());
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator onTime()
    {
        yield return new WaitForSeconds(time);
        generatorShip();
        StartCoroutine(onTime());
    }
    public void generatorShip()
    {
        // spaceShips.Add(ship);
        spaceShips.Add(Instantiate(ship, transform));
        score.scorevalue += 1;

    }
}
