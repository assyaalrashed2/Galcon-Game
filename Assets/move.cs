using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Transform togo;
    float speed = 4;
    public bool colliding = false;
    public GameObject g;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!colliding)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, togo.position);
            transform.position = Vector2.MoveTowards(transform.position, togo.position, speed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == g.tag)
        { colliding = true;
        }
    }

}
