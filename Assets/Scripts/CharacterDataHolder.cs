using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterDataHolder : DataHolder
{
    public void LoadData(IDataHandler dataHandler)
    {
        LoadData<CharacterData>(dataPath, dataHandler);
    }

    [ContextMenu("SaveCharData")]
    public void Test_SaveCharData()
    {
        var dataHandler = new DataHandlerJSON();
        SaveData(dataPath, dataHandler);
    }

    [ContextMenu("LoadCharData")]
    public void Test_LoadCharData()
    {
        var dataHandler = new DataHandlerJSON();
        LoadData<CharacterData>(dataPath, dataHandler);
    }

    [ContextMenu("PrintData")]
    public void Test_PrintData()
    {
        Debug.Log(this.Data.ToString());
    }

    [ContextMenu("test_))")]
    public void Test_0()
    {
        CharacterData newData = new CharacterData("Neko", 13, "Sprites/CharacterSprite_1", "Characters/Character_2");
        var newData1 = new LevelData("bath", "bathroom", 0, "Sprites/LevelSprite_1");
        Data = newData;
    }
}

