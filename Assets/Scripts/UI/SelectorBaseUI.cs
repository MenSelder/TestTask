using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class SelectorBaseUI : MonoBehaviour, IHasHolder
{
    [SerializeField] protected List<Button> buttons;

    [SerializeField] protected Transform infoHolder;

    protected virtual void Awake()
    {
        foreach (var button in buttons)
        {
            button.onClick.AddListener(delegate { ButtonClicked(button); });
        }
    }

    protected abstract void ButtonClicked(Button senderButton);

    public void ClearHolder(Transform holder)
    {
        if (holder.childCount <= 0) return;

        foreach (Transform child in holder)
        {
            Destroy(child.gameObject);
        }
    }
}
