using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetEnvironVolume : MonoBehaviour
{

    public AudioMixer mixer;
    public Slider slider;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("EnvironVolume", 0.15f);
    }
    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("EnvironVol", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("EnvironVolume", sliderValue);
    }
}