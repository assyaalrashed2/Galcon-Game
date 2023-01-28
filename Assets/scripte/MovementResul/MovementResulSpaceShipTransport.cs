using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementResulSpaceShipTransport : MonoBehaviour
{
 // public  SpaceShip ship;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void moveResult(Player player, List<planet> planet1, planet planet2)
    {
        for(int i=0;i<planet1.Count;i++)
        {
            int sum_ship_planet1 = planet1[i].spaceShips.Count;
            planet1[i].spaceShips.RemoveRange(planet1[i].spaceShips.Count / 2, planet1[i].spaceShips.Count / 2);
            for(int j=0;j<sum_ship_planet1/2;j++)
            {
                Instantiate(player.ship, planet1[i].transform.position, Quaternion.LookRotation(Vector3.forward, planet2.transform.position));
                player.ship.togo = planet2.transform;
            }
        }
   
    }
}
