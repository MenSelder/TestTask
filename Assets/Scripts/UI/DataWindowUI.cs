using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class DataWindowUI<T> : MonoBehaviour
    where T : IDataContainer
{
    [SerializeField] private Button closeButton;

    private void Awake()
    {
        closeButton.onClick.AddListener(() => Destroy(gameObject));
    }

    public abstract void SetData(T data);
}
