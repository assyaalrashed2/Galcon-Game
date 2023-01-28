using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_PlayerHuman : MoveGame
{
    public List<planet> planets;
    planet p1;
    planet p2;
    public Player player_Human;
    public Player player_Auto;
    MovementResulCollectiveAttack move;
    MovementResulSpaceShipTransport moveT;
    MoveFactory move1;
    void Start()
    {
        //  planets = new List<planet>();
        p1 = new planet();
        p2 = new planet();
        move = new MovementResulCollectiveAttack();
        move1 = new MoveFactory();
        moveT = new MovementResulSpaceShipTransport();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit, hit1;
        if (Input.GetMouseButtonDown(0))  //اذا كبست بالزر اليسار
        {

            Vector2 origin = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            hit = Physics2D.Raycast(origin, Vector2.zero, 0f);
            //  hit_point = hit.point;
            // p1 = hit.collider.GetComponent<ClickOn>().ClickMe();
            p1 = hit.collider.GetComponent<planet>().ClickMe();
            if (player_Human.planets.Contains(p1)&&!planets.Contains(p1))
            {
                planets.Add(p1);
            }
        }
        if (Input.GetMouseButtonDown(1))
        {

            Vector2 origin1 = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            hit1 = Physics2D.Raycast(origin1, Vector2.zero, 0f);
            //   hit1_point = hit1.point;
            p2 = hit1.collider.GetComponent<planet>().ClickMe();
            if (move1.isCoolectionAttack(player_Human,planets,p2))
            {
                move.moveResult(player_Human, player_Auto, planets, p2);
                
            }
            else if(move1.isSpaceShipTransport(player_Human,planets,p2))
            {
              
                moveT.moveResult(player_Human, planets, p2);
            }
            planets.Clear();
        }

    }

}

