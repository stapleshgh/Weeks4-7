using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glimbo : MonoBehaviour
{
    Vector3 velocity;
    Vector3 mousePos;


    public float acceleration;
    public float speed;
    public float maxSpeed;
    public float timer;
    public Color color;
    
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();

        spriteRenderer.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        //grab mouse position and translate it to world coordinates
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //run the Approach Cursor function
        approachCursor();

        //apply velocity
        transform.position += velocity;

        //look at mouse
        Vector2 direction = mousePos - transform.position;
        transform.up = direction;

        
    }

    void approachCursor()
    {
        if (transform.position != mousePos)
        {
            //x direction velocity
            if (transform.position.x < mousePos.x)
            {
                velocity.x += speed * Time.deltaTime * Vector2.Distance(transform.position, mousePos); ;
            } 
            else if (transform.position.x > mousePos.x)
            {
                velocity.x -= speed * Time.deltaTime * Vector2.Distance(transform.position, mousePos); ;
            }

            //y direction velocity
            if (transform.position.y < mousePos.y)
            {
                velocity.y += speed * Time.deltaTime * Vector2.Distance(transform.position, mousePos); ;
            }
            else if (transform.position.y > mousePos.y)
            {
                velocity.y -= speed * Time.deltaTime * Vector2.Distance(transform.position, mousePos); ;
            }

        }

        //clamp velocity to max speed
        
        velocity.x = Mathf.Clamp(velocity.x, -maxSpeed, maxSpeed);
        velocity.y = Mathf.Clamp(velocity.y, -maxSpeed, maxSpeed);

        
    }
}
