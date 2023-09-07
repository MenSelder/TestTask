using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public interface IDataContainer
{
    public void SetData(IDataContainer data);

    public string ToString();
}
