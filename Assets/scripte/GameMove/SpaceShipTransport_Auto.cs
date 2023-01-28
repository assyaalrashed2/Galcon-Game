using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipTransport_Auto : MonoBehaviour
{
    public Player player_Auto;
    MoveFactory move1;
    MovementResulSpaceShipTransport move;
    void Start()
    {
        move1 = new MoveFactory();
        move = new MovementResulSpaceShipTransport();
    }

    void Update()
    {
        
    }

    public void transport_ship()
    {
        int index_planet_transForm = Random.Range(0, player_Auto.planets.Count);
        int index_planet_transTo = Random.Range(0, player_Auto.planets.Count);
      //  if(move1.isSpaceShipTransport(player_Auto,player_Auto.planets[index_planet_transForm],player_Auto.planets[index_planet_transTo]))
        //{
          //  move.moveResult(player_Auto, player_Auto.planets[index_planet_transForm], player_Auto.planets[index_planet_transTo]);
        //}
    }
}
