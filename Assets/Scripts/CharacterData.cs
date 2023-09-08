public class CharacterData : IDataContainer
{
    public string Name;
    public int Level;
    public string AvatarSpritePath;
    public string ModelPath;

    public CharacterData(string name, int level, string avatarSpriteName, string modeIPath)
    {
        this.Name = name;
        this.Level = level;
        this.AvatarSpritePath = avatarSpriteName;
        this.ModelPath = modeIPath;
    }

    public void SetData(IDataContainer newData)
    {
        var data = newData as CharacterData;

        this.Name = data.Name;
        this.Level = data.Level;
        this.AvatarSpritePath = data.AvatarSpritePath;
        this.ModelPath = data.ModelPath;
    }

    public override string ToString()
    {
        return string.Format("name: {0}; level {1}", Name, Level);
    }
}