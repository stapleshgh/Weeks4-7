using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttoncode : MonoBehaviour
{

    public Button button1;
    public Button layer1;
    public Button layer2;
    public Button layer3;

    public AnimationCurve curve;

    public float t;

    bool pressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        layer1.image.transform.localScale = new Vector2(curve.Evaluate(t), curve.Evaluate(t));
        layer2.image.transform.localScale = new Vector2(curve.Evaluate(t), curve.Evaluate(t));
        layer3.image.transform.localScale = new Vector2(curve.Evaluate(t), curve.Evaluate(t));


        if (pressed)
        {

            if (t < 1)
            {
                t += 3 * Time.deltaTime;
                

            }
            
        }
        else
        {  
            if (t > 0)
            {
                t -= 3 * Time.deltaTime;
            }
            
        }
    }

    public void playAnimation()
    {
        if (pressed)
        {
            pressed = false;
            t = 1;
        }
        else{
            pressed = true;
            t = 0;
        }
       
    }
}
