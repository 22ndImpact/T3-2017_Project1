using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

[Serializable]
public class DataManager
{

    //NOTE, THIS CODE HAS YET TO BE TESTED DO NOT ASSUME FUNCTIONALITY - "Mitchell"

    /// <summary>
    /// Returns yes if a save file at the designated path exists within the streaming assets
    /// </summary>
    public bool SaveDataFound (string _dataPath)
    {
        if (File.Exists(Application.streamingAssetsPath + _dataPath))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Saves movement data to an external file
    /// </summary>
    public void SaveMovementDataList(MovementDataList _movementData, string _dataPath)
    {
        //Create the serializer
        XmlSerializer serializer = new XmlSerializer(typeof(MovementDataList));
        //Create the stream
        FileStream stream = new FileStream(Application.streamingAssetsPath + _dataPath, FileMode.Create);
        //Saves the data
        serializer.Serialize(stream, _movementData);
        //Closes the stream
        stream.Close();
    }

    /// <summary>
    /// Loads movement data from an external file
    /// </summary>
    public MovementDataList LoadedMovementDataList(string _dataPath)
    {
        //Create the serializer
        XmlSerializer serializer = new XmlSerializer(typeof(MovementDataList));
        //Create the stream
        FileStream stream = new FileStream(Application.streamingAssetsPath + _dataPath, FileMode.Open);
        //Loads the data and applies it to the given leveldata
        MovementDataList movementDataList = serializer.Deserialize(stream) as MovementDataList;
        //Cloase the stream
        stream.Close();
        //Returns the new level data
        return movementDataList;
    }
}
