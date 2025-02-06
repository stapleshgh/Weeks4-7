using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float t;
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = t;
        if (slider.value <= slider.maxValue) 
        {
            t += 1 * Time.deltaTime;
        }
        
    }
}
