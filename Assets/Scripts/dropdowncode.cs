using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class dropdowncode : MonoBehaviour
{

    public AnimationCurve curve;

    public TMP_Dropdown dropdown;

    float t;

    bool pressed;

    // Start is called before the first frame update
    void Start()
    {
        pressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        dropdown.image.transform.localScale = new Vector2(curve.Evaluate(t), curve.Evaluate(t));


        if (pressed && t < 1)
        {
            t += 3 * Time.deltaTime;
        } else if (!pressed && t > 0)
        {
            t -= 3 * Time.deltaTime;
        }
    }

    public void clicked()
    {
        if (pressed)
        {
            t = 1;
            pressed = false;
        } else
        {
            t = 0;
            pressed = true;
        }
    }
}
