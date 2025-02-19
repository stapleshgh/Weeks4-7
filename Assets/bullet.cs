using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float time;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        time -= Time.deltaTime;

        transform.position += transform.up * speed * Time.deltaTime;

        if (time < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
