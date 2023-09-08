using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.IO;

public class SelectedPlayerHolderUI : DataWindowUI<CharacterData>
{
    [SerializeField] private TextMeshProUGUI nameHolder;
    [SerializeField] private TextMeshProUGUI levelHolder;
    [SerializeField] private Image iconHolder;
    [SerializeField] private Transform modelHolder;

    public override void SetData(CharacterData characterData)
    {
        nameHolder.text = characterData.name;
        levelHolder.text = characterData.level.ToString();

        var sprite = Resources.Load<Sprite>(characterData.avatarSpritePath);
        iconHolder.sprite = sprite;

        var prefab = Resources.Load<GameObject>(characterData.modelPath); // ??
        var modelObject = Instantiate(prefab, modelHolder); 
    }

}
