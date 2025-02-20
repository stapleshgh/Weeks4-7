using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Main : MonoBehaviour
{
    public GameObject UI;
    public Button spawnButton;
    public Slider speedSlider;
    public Slider maxSpeedSlider;
    public Slider sizeSlider;
    public Slider hueSlider;

    public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        //adds the glimbo release function as a listener to the button object
        spawnButton.onClick.AddListener(letEmLoose);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void letEmLoose()
    {
        //function is called using values from the UI
        Color colour = Color.HSVToRGB(hueSlider.value, 1.0f, 1.0f);
        float scale = sizeSlider.value;
        float speed = speedSlider.value;
        float maxSpeed = maxSpeedSlider.value;
        spawner.GetComponent<spawner>().spawnGlimbo(colour, scale, speed, maxSpeed);

    }
}
