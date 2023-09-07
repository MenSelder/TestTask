using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataHolder
{
    public void SaveData(string fileName, IDataHandler dataHandler);

    public void LoadData<T>(string fileName, IDataHandler dataHandler)
        where T : IDataContainer;

    public void ClearData();
}
