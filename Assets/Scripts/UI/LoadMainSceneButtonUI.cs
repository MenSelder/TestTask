using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadMainSceneButtonUI : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            int mainSceneId = 0;
            SceneManager.LoadScene(mainSceneId);
        });

        GetComponent<Button>().Select();
    }
}
