using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
