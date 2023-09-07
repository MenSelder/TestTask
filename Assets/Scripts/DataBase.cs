using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;

public abstract class DataBase : MonoBehaviour
{    
    public void PullData(string fileName)
    {
        DataHandler dataHandler = new DataHandler();
        dataHandler.SaveData(this, fileName);
    }

    protected abstract void GetData(string fileName);

    protected abstract void SetData(DataBase data);
}
