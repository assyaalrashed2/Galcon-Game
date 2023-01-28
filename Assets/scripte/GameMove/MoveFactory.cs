using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFactory
{
  // player p =new player();

    public bool isAttack(Player player,planet planet_Attack,planet planet_Gool)
    {

        if (player.planets.Contains(planet_Attack)&&!player.planets.Contains(planet_Gool))
            return true;
        else return false;
    }
    public bool isCoolectionAttack(Player player,List<planet>planet_attack, planet planet_Gool)
    {

        if (!player.planets.Contains(planet_Gool)&&planet_attack.Count!=0)
            return true;
         else return false;
        
    }

   public bool isSpaceShipTransport(Player player, List <planet> planet_transport, planet planet_Gool)
    {
        if (planet_transport.Count!=0 &&player.planets.Contains(planet_Gool))
            return true;
        else return false;
    }
    
}
