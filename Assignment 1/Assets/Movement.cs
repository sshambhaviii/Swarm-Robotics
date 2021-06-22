using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
   
        float circleSpeed = 1f;
        float circleSize = 0.1f;
        float circleGrowSpeed = 0.001f;
        float timeCounter = 0;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        float x = Mathf.Sin(timeCounter* circleSpeed) * circleSize;
        float y = 0;
        float z=Mathf.Cos(timeCounter* circleSpeed) * circleSize; 
        transform.position= new Vector3(x,y,z);
        circleSize += circleGrowSpeed;

    }
}



