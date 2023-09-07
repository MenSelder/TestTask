using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataHandler
{
    private const string DATA_FOLDER = "Datas";

    private string GetPath(string fileName)
    {
        return Application.dataPath + Path.AltDirectorySeparatorChar + DATA_FOLDER
            + Path.AltDirectorySeparatorChar + fileName + ".json";
    }

    public void SaveData(DataBase data, string fileName)
    {
        string path = GetPath(fileName);

        string json = JsonUtility.ToJson(data);
        using StreamWriter streamWriter = new StreamWriter(path);
        streamWriter.Write(json);
    }

    public void LoadData(string fileName, object obj)
    {
        string path = GetPath(fileName);

        using StreamReader streamReader = new StreamReader(path);
        string json = streamReader.ReadToEnd();

        JsonUtility.FromJsonOverwrite(json, obj);

        //T data = JsonUtility.FromJsonOverwrite<T>(json, obj);
        //return data;
    }

}
