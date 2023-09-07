using System;

public interface IDataHandler
{
    public void SaveData(IDataContainer data, string fileName);
    //public IDataContainer LoadData(string fileName);
    public T LoadData<T>(string fileName) where T : IDataContainer;
}
