using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textAnimation : MonoBehaviour
{
    float timer = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer < 2 && timer >3)
        
            GetComponent<Text>().text = "Loading.";
        else if (timer < 1 && timer > 2)

            GetComponent<Text>().text = "Loading..";
        else if (timer < 0 && timer > 1)

            GetComponent<Text>().text = "Loading...";
        else if (timer <= 0)

            timer = 3;
        timer -= Time.deltaTime;
    }
}
