using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    Player player_human,player_auto;
    public GameObject game;
    // Start is called before the first frame update
    void Start()
    {
        player_human = new HumanPlayer();
      //  player_human.planets.Add(game);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
