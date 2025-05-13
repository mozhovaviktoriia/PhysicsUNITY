using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsUpdate : MonoBehaviour
{
    public float speed = 0.5f;
    float timeStartOffset = 0;
    bool gotStartTime = false;
    void Update()
    {
        if(!gotStartTime)
        {
            timeStartOffset = Time.realtimeSinceStartup;
            gotStartTime = true;
        }
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y,
            (Time.realtimeSinceStartup - timeStartOffset) * speed);
    }
}
