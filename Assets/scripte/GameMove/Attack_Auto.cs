using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_Auto : MoveGame
{
    public GameAreans planet_Game;
    public Player player_Auto;
    public Player player_human;
    MoveFactory move1;
    MovementResulAttack move;

    int num;
    // Start is called before the first frame update
    void Start()
    {
        // planet_Game = new GameAreans();
        move1 = new MoveFactory();
        move = new MovementResulAttack();
    }

    // Update is called once per frame
    void Update()
    {
       if (player_Auto.planets.Count < planet_Game.planets.Count)
        { 
        Invoke("attack", 3.0f);
        }
    }
  public void attack()
    {
        int index_planetG = Random.Range(0, planet_Game.planets.Count);
        int index_planetA = Random.Range(0, player_Auto.planets.Count);
        if (move1.isAttack(player_Auto, player_Auto.planets[index_planetA], planet_Game.planets[index_planetG]))
        {
            move.moveResult(player_Auto, player_human, player_Auto.planets[index_planetA], planet_Game.planets[index_planetG]);
        }
        
    }
}
