using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementResulAttack : MovementResul
{
    Color32 blue;
    Color32 red;
   public SpaceShip ship;
    void Start()
    {
     red = new Color32();
     blue = new Color32();
       
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  //  override
     public void moveResult(Player player,Player player_opponent, planet planet_Attack, planet planet_Gool)
    {
        int num_spaceship_Attack=planet_Attack.spaceShips.Count/2;
       int num_spaceship_Gool = planet_Gool.spaceShips.Count -(planet_Attack.spaceShips.Count / 2);
        
        if (planet_Gool.spaceShips.Count>= planet_Attack.spaceShips.Count / 2)
        {
          //  int numNewShipGool = planet_Attack.spaceShips.Count / 2 - planet_Gool.spaceShips.Count;
            ///planet_Attack.spaceShips.RemoveRange(planet_Attack.spaceShips.Count / 2, num_spaceship_Attack);
            planet_Gool.spaceShips.RemoveRange(num_spaceship_Gool, num_spaceship_Attack);
            planet_Attack.spaceShips.RemoveRange(planet_Attack.spaceShips.Count / 2, num_spaceship_Attack);
            //  print("assya");
        }
        else
        {
            int numNewShipGool = planet_Attack.spaceShips.Count / 2 - planet_Gool.spaceShips.Count;
            planet_Attack.spaceShips.RemoveRange(planet_Attack.spaceShips.Count / 2, num_spaceship_Attack);
            planet_Gool.spaceShips.Clear();
            
            if(player_opponent.planets.Contains(planet_Gool))
            {
                player_opponent.planets.Remove(planet_Gool);
            }
            if (player.tag.Equals("playerHuman"))
            {
                red.a = 225;
                red.b = 14;
                red.g = 14;
                red.r = 229;
                planet_Gool.sprite.color =red;

            }
            else
            {
                
                blue.a = 255;
                blue.b = 253;
                blue.g = 44;
                blue.r = 16;
                planet_Gool.sprite.color = blue;
            }
            player.planets.Add(planet_Gool);
            for(int i=0;i<numNewShipGool;i++)
            {
                planet_Gool.spaceShips.Add(ship);
            }
            print("gogo");
        }
    }
}
