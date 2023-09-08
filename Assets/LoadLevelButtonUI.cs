using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevelButtonUI : MonoBehaviour
{
    [SerializeField] private SelectedLevelDataHolderUI selectedLevelDataHolderUI;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            LevelData levelData = selectedLevelDataHolderUI.Data;
            int levelId = levelData.LevelId;

            SceneManager.LoadScene(levelId);
        });
    }
}
