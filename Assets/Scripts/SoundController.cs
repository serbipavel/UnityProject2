using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : Sounds
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlaySound(0, p1:1f, p2:1f /*, destroyed:true*/);
            //Destroy(gameObject);
        }
    }
}
