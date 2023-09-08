using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayersSelectorUI : SelectorBaseUI, IHasHolder
{
    private const string PATH = "Prefabs/UI/SelectedPlayerDataHolder";

    protected override void ButtonClicked(Button senderButton)
    {
        ClearHolder(infoHolder);
                
        var dataHolder = senderButton.GetComponent<CharacterDataHolder>();
        DataHandlerJSON dataHandler = new DataHandlerJSON();
        dataHolder.LoadData(dataHandler);

        var prefab = Resources.Load<GameObject>(PATH);
        var selectedPlayerInfo = Instantiate(prefab, infoHolder);
        selectedPlayerInfo.GetComponent<SelectedPlayerDataHolderUI>().SetData(dataHolder.Data as CharacterData);

        dataHolder.ClearData();
    }

    private void Start()
    {
        buttons[0].Select();
    }
}
