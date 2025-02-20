using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void spawnGlimbo(Color c, float scale, float speed, float maxSpeed)
    {
        //create position for glimbo
        var pos = new Vector2(0, 0);
        //create glimbo instance
        var g = Instantiate(prefab, pos, Quaternion.identity);
        //grab glimbo script
        var script = g.GetComponent<glimbo>();

        //assign glimbo attributes
        g.transform.localScale = new Vector3(scale, scale, scale);
        script.color = c;
        script.speed = speed;
        script.maxSpeed = maxSpeed;

        //set glimbo up to Die
        Destroy(g, script.timer);

    }
}
