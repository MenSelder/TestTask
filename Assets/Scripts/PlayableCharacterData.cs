using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//make pure data class...

public class PlayableCharacterData : DataBase
{
    [SerializeField] private string dataFileName;
    //Data data = null

    // Make private !!

    public string name;
    public int level;
    public int avatarId;
    public int modelId;

    public PlayableCharacterData(string dataFileName, string name, int level, int avatarId, int modelId)
    {
        this.dataFileName = dataFileName;
        this.name = name;
        this.level = level;
        this.avatarId = avatarId;
        this.modelId = modelId;
    }

    protected override void SetData(DataBase dataBase)
    {
        var data = dataBase as PlayableCharacterData;

        this.name = data.name;
        this.level = data.level;
        this.avatarId = data.avatarId;
        this.modelId = data.modelId;
    }

    protected override void GetData(string fileName)
    {
        DataHandler dataHandler = new DataHandler();
        dataHandler.LoadData(fileName, this);
        //var data = dataHandler.LoadData<PlayableCharacterData>(fileName);

        //SetData(data);
    }    

    [ContextMenu("PullData")]
    public void test_PullData()
    {
        PullData(dataFileName);
    }

    [ContextMenu("GetData")]
    public void test_GetData()
    {
        GetData(dataFileName);
    }
}
