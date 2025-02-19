using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class tank : MonoBehaviour
{
    Vector3 mousePos;
    public GameObject gunPivot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        Vector2 direction = mousePos - gunPivot.transform.position;

        gunPivot.transform.up = direction;




    }
}
