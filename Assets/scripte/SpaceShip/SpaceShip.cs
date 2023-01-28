using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    //public GameObject spaceship;
    // Start is called before the first frame update
    float speed = 8f;
   public Transform togo;
    public bool isMoving=false;
    void Start()
    {

        if (transform == togo)
        {
            isMoving = false;
            
        }
        else { isMoving = true; }
    }
    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            move_ship();
        }
        
    }
    public void move_ship()
    {
   
         transform.rotation = Quaternion.LookRotation(Vector3.forward, togo.position);
        transform.position = Vector2.MoveTowards(transform.position, togo.position, speed * Time.deltaTime);
    
    }
   public void end_move()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform==togo)
        {
            Destroy(gameObject);
            
        }
    }
}
