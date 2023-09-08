using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;

public class DataHolder : MonoBehaviour, IDataHolder
{
    public IDataContainer Data { get; protected set; }

    public void ClearData() => Data = null;

    public void LoadData<T>(string fileName, IDataHandler dataHandler) where T : IDataContainer
    {
        T data = dataHandler.LoadData<T>(fileName);
        Data = data;
    }

    public void SaveData(string fileName, IDataHandler dataHandler)
    {
        dataHandler.SaveData(Data, fileName);
    }
}
