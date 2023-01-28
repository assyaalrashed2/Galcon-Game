using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementResulCollectiveAttack : MovementResul
{
    SpaceShip ship;
    Color32 blue;
    Color32 red;
    // Start is called before the first frame update
    void Start()
    {
        red = new Color32();
        blue = new Color32();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // override
    public void moveResult(Player player, Player player_opponent, List<planet> planet_Attack, planet planet_Gool)
    {
        planet_Gool.p = player;
        planet_Gool.p2 = player_opponent;
        if (player.tag.Equals("playerHuman"))
        {
            planet_Gool.tag_new = "Red";
            red.a = 225;
            red.b = 14;
            red.g = 14;
            red.r = 229;
            planet_Gool.color = red;
        }
        else
        {
            planet_Gool.tag_new = "Blue";

            blue.a = 255;
            blue.b = 253;
            blue.g = 44;
            blue.r = 16;
            planet_Gool.color = blue;
        }
     
        for (int i = 0; i < planet_Attack.Count; i++)
        {
            int sum_ship_attack = planet_Attack[i].spaceShips.Count;
            planet_Attack[i].spaceShips.RemoveRange(planet_Attack[i].spaceShips.Count / 2, planet_Attack[i].spaceShips.Count / 2);
            print("bbbbbbbbbbbbbbbbbb");
            for (int j = 0; j < sum_ship_attack / 2; j++)
            {
                Instantiate(player.ship, planet_Attack[i].transform.position, Quaternion.LookRotation(Vector3.forward, planet_Gool.transform.position));
                player.ship.togo = planet_Gool.transform;
            
            }
            sum_ship_attack = 0;
        }
    }
     
}
