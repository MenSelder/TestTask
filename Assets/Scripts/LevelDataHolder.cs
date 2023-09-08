public class LevelDataHolder : DataHolder
{    public void LoadData(IDataHandler dataHandler)
    {
        LoadData<LevelData>(dataPath, dataHandler);
    }
}
