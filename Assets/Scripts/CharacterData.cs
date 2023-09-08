public class CharacterData : IDataContainer
{
    public string Name;
    public int Level;
    public string AvatarSpritePath;
    public string ModelPath;

    public CharacterData(string name, int level, string avatarSpritePath, string modeIPath)
    {
        Name = name;
        Level = level;
        AvatarSpritePath = avatarSpritePath;
        ModelPath = modeIPath;
    }

    public void SetData(IDataContainer newData)
    {
        var data = newData as CharacterData;

        Name = data.Name;
        Level = data.Level;
        AvatarSpritePath = data.AvatarSpritePath;
        ModelPath = data.ModelPath;
    }

    public override string ToString()
    {
        return string.Format("name: {0}; level {1}", Name, Level);
    }
}