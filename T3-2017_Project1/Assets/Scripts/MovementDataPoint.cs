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

public class MovementDataList
{
    public List<MovementDataPoint> dataList;
    public int versionNumber;

    //Constructor
    public MovementDataList(int version)
    {
        this.dataList = new List<MovementDataPoint>();
        this.versionNumber = version;
    }

    //Constructor
    public MovementDataList(int version, List<MovementDataPoint> list)
    {
        this.dataList = list;
        this.versionNumber = version;
    }
}
