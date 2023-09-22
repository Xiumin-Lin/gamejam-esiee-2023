using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class SettingsUI : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private Transform volumePercentageTMPro;
    public AudioMixer audioMixer;   

    void Awake()
    {
        volumePercentageTMPro.GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetInt("volumeSliderPercent") + "%";
        volumeSlider.value = PlayerPrefs.GetFloat("volume");  
    }

    public void SetVolume(float volume)
    {
        int volumeSliderPercent = (int) (volume - volumeSlider.minValue) * 2;
        volumePercentageTMPro.GetComponent<TMPro.TextMeshProUGUI>().text = volumeSliderPercent.ToString() + "%";
        audioMixer.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("volume", volume);
        PlayerPrefs.SetInt("volumeSliderPercent", volumeSliderPercent);
        /*Debug.Log(volume);
        Debug.Log(volumeSliderPercent);*/
    }
}
