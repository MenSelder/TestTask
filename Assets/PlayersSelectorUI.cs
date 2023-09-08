using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayersSelectorUI : MonoBehaviour
{
    private const string PATH = "Prefabs/UI/SelectedPlayerHolder";

    [SerializeField] private Button ChosePlayerButton_1;
    [SerializeField] private Button ChosePlayerButton_2;
    [SerializeField] private Transform infoHolder;

    private void Awake()
    {
        ChosePlayerButton_1.onClick.AddListener(() =>
        {
            ButtonClick(ChosePlayerButton_1);
        });
        ChosePlayerButton_2.onClick.AddListener(() =>
        {
            ButtonClick(ChosePlayerButton_2);
        });
    }

    private void ButtonClick(Button senderButton)
    {
        ClearHolder(infoHolder);
                
        var dataHolder = senderButton.GetComponent<CharacterDataHolder>();
        DataHandlerJSON dataHandler = new DataHandlerJSON();
        dataHolder.LoadData(dataHandler);

        var prefab = Resources.Load<GameObject>(PATH);
        var selectedPlayerInfo = Instantiate(prefab, infoHolder);
        selectedPlayerInfo.GetComponent<SelectedPlayerHolderUI>().SetData(dataHolder.Data as CharacterData);
    }

    private void Start()
    {
        ChosePlayerButton_1.Select();
    }

    

    private void ClearHolder(Transform holder)
    {
        if (holder.childCount <= 0) return;

        foreach (Transform child in holder)
        {
            Destroy(child.gameObject);
        }
    }
}
