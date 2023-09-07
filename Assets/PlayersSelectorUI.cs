using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersSelectorUI : MonoBehaviour
{
    [SerializeField] private Button ChosePlayerButton_1;
    [SerializeField] private Button ChosePlayerButton_2;

    private void Start()
    {
        ChosePlayerButton_1.Select();
    }
}
