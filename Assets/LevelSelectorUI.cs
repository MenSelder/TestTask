using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectorUI : SelectorBaseUI, IHasHolder
{
    private const string PATH = "Prefabs/UI/SelectedLevelDataHolder";

    protected override void ButtonClicked(Button senderButton)
    {
        ClearHolder(infoHolder);

        var dataHolder = senderButton.GetComponent<LevelDataHolder>();
        DataHandlerJSON dataHandler = new DataHandlerJSON();
        dataHolder.LoadData(dataHandler);

        var prefab = Resources.Load<GameObject>(PATH);
        var selectedPlayerInfo = Instantiate(prefab, infoHolder);
        selectedPlayerInfo.GetComponent<SelectedLevelDataHolderUI>().SetData(dataHolder.Data as LevelData);

        dataHolder.ClearData();
    }
}
