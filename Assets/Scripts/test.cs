using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            if (audioSource.isPlaying == false)
            {
                audioSource.PlayOneShot(clip);
            }
            

        }


    }
}
