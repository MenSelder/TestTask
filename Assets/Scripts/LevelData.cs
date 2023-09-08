using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : IDataContainer
{
    public string name;
    public string description;
    public int levelId;
    public string iconSpriteName;

    public LevelData(string name, string description, int levelId, string iconSpriteName)
    {
        this.name = name;
        this.description = description;
        this.levelId = levelId;
        this.iconSpriteName = iconSpriteName;
    }

    public void SetData(IDataContainer newData)
    {
        var data = newData as LevelData;

        this.name = data.name;
        this.description = data.description;
        this.levelId = data.levelId;
        this.iconSpriteName = data.iconSpriteName;
    }

    public override string ToString()
    {
        return string.Format("name: {0}; description {1}", name, description);
    }
}
