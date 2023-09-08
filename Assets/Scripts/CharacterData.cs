public class CharacterData : IDataContainer
{
    public string name;
    public int level;
    public string avatarSpritePath;
    public string modelPath;

    public CharacterData(string name, int level, string avatarSpriteName, string modeIPath)
    {
        this.name = name;
        this.level = level;
        this.avatarSpritePath = avatarSpriteName;
        this.modelPath = modeIPath;
    }

    public void SetData(IDataContainer newData)
    {
        var data = newData as CharacterData;

        this.name = data.name;
        this.level = data.level;
        this.avatarSpritePath = data.avatarSpritePath;
        this.modelPath = data.modelPath;
    }

    public override string ToString()
    {
        return string.Format("name: {0}; level {1}", name, level);
    }
}