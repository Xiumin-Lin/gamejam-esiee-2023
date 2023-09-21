using System.Collections;
using System.Collections.Generic;
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
        PlayerPrefs.SetFloat("volume", -30f);
        PlayerPrefs.SetInt("volumeSliderPercent", 50);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("InGameUI");
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
