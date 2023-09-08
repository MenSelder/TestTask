using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class DataHandlerJSON : IDataHandler
{
    private const string DATA_FOLDER = "Datas";

    private string GetPath(string fileName)
    {
        return Application.dataPath + Path.AltDirectorySeparatorChar + DATA_FOLDER
            + Path.AltDirectorySeparatorChar + fileName + ".json";
    }

    public void SaveData(IDataContainer data, string fileName)
    {
        string path = GetPath(fileName);

        string json = JsonUtility.ToJson(data);
        using StreamWriter streamWriter = new StreamWriter(path);
        streamWriter.Write(json);
    }

    public T LoadData<T>(string fileName) where T : IDataContainer
    {
        string path = GetPath(fileName);

        using StreamReader streamReader = new StreamReader(path);
        string json = streamReader.ReadToEnd();

        T data = JsonUtility.FromJson<T>(json);
        return data;
    }
}
