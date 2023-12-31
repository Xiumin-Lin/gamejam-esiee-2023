using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button quitButton;
    
    void Awake()
    {
        playButton.onClick.AddListener(ChangeScene);
        quitButton.onClick.AddListener(QuitGame);

        // PlayerPrefs son
        PlayerPrefs.SetFloat("volume", -5f);
        PlayerPrefs.SetInt("volumeSliderPercent", 75);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("InGameUI", LoadSceneMode.Single);
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
