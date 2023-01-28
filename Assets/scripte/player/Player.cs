using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<planet> planets;
    public SpaceShip ship;
    void Start()
    {
       // ship = new SpaceShipNormal();
       
            
     }

    // Update is called once per frame
    void Update()
    {
        if (ship.transform == ship.togo)
        {
            Destroy(ship);
           
        }
    }

}
