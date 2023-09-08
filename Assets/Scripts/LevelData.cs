using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : IDataContainer
{
    public string Name;
    public string Description;
    public int LevelId;
    public string IconSpritePath;

    public LevelData(string name, string description, int levelId, string iconSpriteName)
    {
        this.Name = name;
        this.Description = description;
        this.LevelId = levelId;
        this.IconSpritePath = iconSpriteName;
    }

    public void SetData(IDataContainer newData)
    {
        var data = newData as LevelData;

        this.Name = data.Name;
        this.Description = data.Description;
        this.LevelId = data.LevelId;
        this.IconSpritePath = data.IconSpritePath;
    }

    public override string ToString()
    {
        return string.Format("name: {0}; description {1}", Name, Description);
    }
}
