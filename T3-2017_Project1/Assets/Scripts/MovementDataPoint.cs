using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDataPoint
{
    public Vector3 position;
    public Vector3 direction;
    public float timestamp;

    //Constructor
    public MovementDataPoint(Vector3 pos, Vector3 dir, float time)
    {
        this.position = pos;
        this.direction = dir;
        this.timestamp = time;
    }
}
