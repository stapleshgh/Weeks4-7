using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour
{
    public bool colliding;
    public GameObject collidedObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision collision)
    {
        colliding = true;
        collidedObject = collision.gameObject;
    }
}
