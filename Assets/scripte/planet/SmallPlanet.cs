using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallPlanet : planet
{
    // Start is called before the first frame update
    
  //  SpaceShip ship;
    void Start()
    {
        time = 0.8f;
     //   ship = new SpaceShip();
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
