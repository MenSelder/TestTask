using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayableCharacterData : DataHolder
{
    [SerializeField] private string dataFileName; 

    [ContextMenu("SaveCharData")]
    public void Test_SaveCharData()
    {
        var dataHandler = new DataHandlerJSON();
        SaveData(dataFileName, dataHandler);
    }

    [ContextMenu("LoadCharData")]
    public void Test_LoadCharData()
    {
        var dataHandler = new DataHandlerJSON();
        LoadData<CharacterData>(dataFileName, dataHandler);
    }

    [ContextMenu("PrintData")]
    public void Test_PrintData()
    {
        Debug.Log(this.Data.ToString());
    }
}

