using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MixerController : MonoBehaviour 
{
    [SerializeField] private AudioMixer Amix;

    public float MainVol = 100;
    public float MusicVol = 100;
    public float SFXVol = 100;

    public UnityEngine.UI.Slider MainSlider;
    public UnityEngine.UI.Slider MusicSlider;
    public UnityEngine.UI.Slider SFXSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("MainVol") == true)
        {
            //print("has mainVol");
            MainVol = PlayerPrefs.GetFloat("MainVol");
            Amix.SetFloat("MasterVolume", Mathf.Log10(MainVol) * 20);
            MainSlider.value = MainVol;
            
        }
        else
        {

            PlayerPrefs.SetFloat("MainVol", 100f);
        }

        if (PlayerPrefs.HasKey("MusicVol") == true)
        {

            MusicVol = PlayerPrefs.GetFloat("MusicVol");
            Amix.SetFloat("MusicVolume", Mathf.Log10(MusicVol) * 20);
            MusicSlider.value = MusicVol;
        }
        else
        {

            PlayerPrefs.SetFloat("MusicVol", 100f);
        }

        if (PlayerPrefs.HasKey("SFXVol") == true)
        {

            SFXVol = PlayerPrefs.GetFloat("SFXVol");
            Amix.SetFloat("SFXVolume", Mathf.Log10(SFXVol) * 20);
            SFXSlider.value = SFXVol;
        }
        else
        {

            PlayerPrefs.SetFloat("SFXVol", 100f);
        }


    }
    public void SetMasterVolume (float sliderValue)
    {
        Amix.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
        MainVol = sliderValue;
        PlayerPrefs.SetFloat("MainVol", MainVol);
    }

    public void SetMusicVolume(float sliderValue)
    {
        Amix.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
        MusicVol = sliderValue;
        PlayerPrefs.SetFloat("MusicVol", MusicVol);
    }

    public void SetSFXVolume(float sliderValue)
    {
        Amix.SetFloat("SFXVolume", Mathf.Log10(sliderValue) * 20);
        SFXVol = sliderValue;
        PlayerPrefs.SetFloat("SFXVol", SFXVol);
    }
}
