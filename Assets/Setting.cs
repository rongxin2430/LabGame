using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] private AudioSource background;

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void SetVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }
    void Start()
    {
        if(PlayerPrefs.HasKey("musicVolume"))
         {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
         }
        else
        {
            Load();
        }
        background.Play();
    }
    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");   
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
