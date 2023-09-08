public class LevelData : IDataContainer
{
    public string Name;
    public string Description;
    public int LevelId;
    public string IconSpritePath;

    public LevelData(string name, string description, int levelId, string iconSpritePath)
    {
        Name = name;
        Description = description;
        LevelId = levelId;
        IconSpritePath = iconSpritePath;
    }

    public void SetData(IDataContainer newData)
    {
        var data = newData as LevelData;

        Name = data.Name;
        Description = data.Description;
        LevelId = data.LevelId;
        IconSpritePath = data.IconSpritePath;
    }

    public override string ToString()
    {
        return string.Format("name: {0}; description {1}", Name, Description);
    }
}
