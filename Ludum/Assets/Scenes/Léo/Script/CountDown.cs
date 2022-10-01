using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;

    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        print (currentTime);

        if(currentTime <= 0)
        {
            //change player
            currentTime = 10f;
        }
    }
}
