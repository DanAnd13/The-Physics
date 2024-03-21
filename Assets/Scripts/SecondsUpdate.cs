using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsUpdate : MonoBehaviour
{
    float timeOfStart = 0;
    bool isStart = false;
    public float speed = 0.5f;
    void Update()
    {
        if (!isStart)
        {
            timeOfStart = Time.realtimeSinceStartup;
            isStart = true;
        }
        this.transform.position = new Vector3(this.transform.position.x, 
                                              this.transform.position.y, 
                                              (Time.realtimeSinceStartup - timeOfStart) * speed);
    }
}
