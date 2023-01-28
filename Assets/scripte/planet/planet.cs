using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planet : MonoBehaviour
{
    public float time ;
    public GameObject planet1;
    public SpriteRenderer sprite;
    public SpaceShip ship;
    public List<GameObject> spaceShips;
    public int count_ship;
    public Color32 color;
    public string tag_new;
    public Player p;
    public Player p2;
    public Score score;
    void Start()
    {
        spaceShips = new List<GameObject>();
        for(int i=0;i<count_ship;i++)
        {
            spaceShips.Add(Instantiate(ship, transform));
        }
       // score.scorevalue = spaceShips.Count;
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!spaceShips.Contains(collision.gameObject)&&gameObject.tag!=collision.gameObject.tag)
        {
            if(spaceShips.Count-1==0)
            {
                gameObject.tag = tag_new;
                sprite.color = color;
                //  isempty = true;
                if (!p.planets.Contains(this))
                {
                    p.planets.Add(this);
                }
                if(p2.planets.Contains(this))
                {
                    p2.planets.Remove(this);
                }
            }
         //   spaceShips.Remove(spaceShips[0]);
             score.scorevalue -=1 ;
            
        }
      else if (!spaceShips.Contains(collision.gameObject) && gameObject.tag == collision.gameObject.tag)
        {
            spaceShips.Add(Instantiate(ship, transform));
        }

       else if (spaceShips.Contains(collision.gameObject))
        {
            Destroy(collision.gameObject);
            score.scorevalue +=1;
            
        }

        
    }
    public planet ClickMe()
    {
        return this;
    }
}
