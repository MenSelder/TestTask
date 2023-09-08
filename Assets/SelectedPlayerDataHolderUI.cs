using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SelectedPlayerDataHolderUI : DataWindowUI<CharacterData>
{
    [SerializeField] private TextMeshProUGUI nameHolder;
    [SerializeField] private TextMeshProUGUI levelHolder;
    [SerializeField] private Image iconHolder;
    [SerializeField] private Transform modelHolder;

    public override void SetData(CharacterData characterData)
    {
        nameHolder.text = characterData.Name;
        levelHolder.text = characterData.Level.ToString();

        var sprite = Resources.Load<Sprite>(characterData.AvatarSpritePath);
        iconHolder.sprite = sprite;

        var prefab = Resources.Load<GameObject>(characterData.ModelPath);
        var modelObject = Instantiate(prefab, modelHolder);

        Data = characterData;
    }
}
