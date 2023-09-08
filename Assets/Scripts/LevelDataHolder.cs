using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDataHolder : DataHolder
{    public void LoadData(IDataHandler dataHandler)
    {
        LoadData<LevelData>(dataPath, dataHandler);
    }
}
