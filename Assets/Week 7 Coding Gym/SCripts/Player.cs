using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        handleInput();
    }

    void handleInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            velocity.y += speed;
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            velocity.y -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x += speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x -= speed;
        }

        velocity.x = Mathf.Clamp(velocity.x, -maxSpeed, maxSpeed);
        velocity.y = Mathf.Clamp(velocity.y, -maxSpeed, maxSpeed);
    }
}
