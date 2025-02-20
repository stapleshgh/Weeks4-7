using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glimbo : MonoBehaviour
{

    Vector3 mousePos;
    public float acceleration;
    public float speed;
    public float maxSpeed;
    public Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        


        approachCursor();


        transform.position += velocity;



        
    }

    void approachCursor()
    {
        if (transform.position != mousePos)
        {
            //x direction velocity
            if (transform.position.x < mousePos.x)
            {
                velocity.x += speed * Time.deltaTime * Vector2.Distance(transform.position, mousePos);
            } 
            else if (transform.position.x > mousePos.x)
            {
                velocity.x -= speed * Time.deltaTime * Vector2.Distance(transform.position, mousePos);
            }

            //y direction velocity
            if (transform.position.y < mousePos.y)
            {
                velocity.y += speed * Time.deltaTime * Vector2.Distance(transform.position, mousePos);
            }
            else if (transform.position.y > mousePos.y)
            {
                velocity.y -= speed * Time.deltaTime * Vector2.Distance(transform.position, mousePos);
            }

        }

        //clamp velocity to max speed
        
        velocity.x = Mathf.Clamp(velocity.x, -maxSpeed, maxSpeed);
        velocity.y = Mathf.Clamp(velocity.y, -maxSpeed, maxSpeed);

        
    }
}
