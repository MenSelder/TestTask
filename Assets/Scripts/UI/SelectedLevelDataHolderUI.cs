using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelectedLevelDataHolderUI : DataWindowUI<LevelData>
{
    [SerializeField] private TextMeshProUGUI nameHolder;
    [SerializeField] private TextMeshProUGUI idHolder;
    [SerializeField] private TextMeshProUGUI descriptionHolder;
    [SerializeField] private Image iconHolder;

    public override void SetData(LevelData levelData)
    {
        nameHolder.text = levelData.Name;
        idHolder.text = levelData.LevelId.ToString();
        descriptionHolder.text = levelData.Description;

        var sprite = Resources.Load<Sprite>(levelData.IconSpritePath);
        iconHolder.sprite = sprite;

        Data = levelData;
    }
}
