using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_playerAuto_leval2 : MonoBehaviour
{
    public List<planet> planets;
    public GameAreans planet_Game;
    public Player player_Human;
    public Player player_Auto;
    MovementResulCollectiveAttack move;
    MovementResulSpaceShipTransport moveT;
    MoveFactory move1;
    public planet planet_Big ,planet_min;
    float time = 6f;
    void Start()
    {
        move = new MovementResulCollectiveAttack();
        move1 = new MoveFactory();
        moveT = new MovementResulSpaceShipTransport();
        
        if (time > 0)
        {
            StartCoroutine(onTimestart());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator onTimestart()
    {
        yield return new WaitForSeconds(time);
        Move_Auto();
        StartCoroutine(onTimestart());
    }
    void Move_Auto()
    {
        planet_Big = player_Auto.planets[0];
        for(int i=0;i<player_Auto.planets.Count;i++)
        {
            if(planet_Big.spaceShips.Count<player_Auto.planets[i].spaceShips.Count)
            {
                planet_Big = player_Auto.planets[i];
            }
        }
        planets.Add(planet_Big);
        planet_min = planet_Game.planets[0];
        for(int i=0;i<planet_Game.planets.Count;i++)
        {
            if(planet_min.spaceShips.Count>planet_Game.planets[i].spaceShips.Count)
            {
                planet_min = planet_Game.planets[i];
            }
        }
         
        if(!player_Auto.planets.Contains(planet_min))
        {
            print("assya");
            if (move1.isCoolectionAttack(player_Auto, planets, planet_min))
            {
                move.moveResult(player_Auto, player_Human, planets, planet_min);
            }
        }
       
        else 
        {
           if (move1.isSpaceShipTransport(player_Auto, planets,planet_min))
        
            moveT.moveResult(player_Auto, planets, planet_min);
        }
        planets.Clear();
     //   Debug.Log("assya____");
    }
}
