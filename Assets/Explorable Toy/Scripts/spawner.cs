using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    GameObject[] glimbos;

    public GameObject prefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var pos = new Vector2(0, 0);
            var g = Instantiate(prefab, pos, Quaternion.identity);
            var script = g.GetComponent<glimbo>();
            Destroy(g, script.timer);
        }
    }

    void updateGlimbos()
    {
        
    }
}
