using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_PlayerAuto : MonoBehaviour
{
    public List<planet> planets;
    public GameAreans planet_Game;
    public Player player_Human;
    public Player player_Auto;
    MovementResulCollectiveAttack move;
    MovementResulSpaceShipTransport moveT;
    MoveFactory move1;
    float time = 6f;
    void Start()
    {
        move = new MovementResulCollectiveAttack();
        move1 = new MoveFactory();
        moveT = new MovementResulSpaceShipTransport();
        if(time>0)
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
        move_Auto();
        StartCoroutine(onTimestart());
    }
    void move_Auto()
    {
        int index_planetG = Random.Range(0, planet_Game.planets.Count);
        int index_planetA = Random.Range(0, player_Auto.planets.Count);
        if (player_Auto.planets.Contains(planet_Game.planets[index_planetA]))
        {
            planets.Add(planet_Game.planets[index_planetA]);
        }
        if (move1.isCoolectionAttack(player_Auto, planets, planet_Game.planets[index_planetG]))
        {
            move.moveResult(player_Auto, player_Human, planets, planet_Game.planets[index_planetG]);
        }
        else if (move1.isSpaceShipTransport(player_Auto, planets, planet_Game.planets[index_planetG]))
        {
            moveT.moveResult(player_Auto, planets, planet_Game.planets[index_planetG]);
        }
        planets.Clear();
        Debug.Log("assya____");
    }
}
