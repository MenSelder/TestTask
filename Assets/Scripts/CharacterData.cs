public class CharacterData : IDataContainer
{
    public string name;
    public int level;
    public int avatarId;
    public int modelId;

    public CharacterData(string name, int level, int avatarId, int modelId)
    {
        this.name = name;
        this.level = level;
        this.avatarId = avatarId;
        this.modelId = modelId;
    }

    public void SetData(IDataContainer newData)
    {
        var data = newData as CharacterData;

        this.name = data.name;
        this.level = data.level;
        this.avatarId = data.avatarId;
        this.modelId = data.modelId;
    }

    public string ToString()
    {
        return string.Format("name: {0}; level {1}", name, level);
    }
}