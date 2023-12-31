using UnityEngine;
using UnityEngine.UI;

public abstract class DataWindowUI<T> : MonoBehaviour
    where T : IDataContainer
{
    [SerializeField] private Button closeButton;

    public T Data { get; protected set; }

    private void Awake()
    {
        closeButton.onClick.AddListener(() => Destroy(gameObject));
    }

    public abstract void SetData(T data);
}
