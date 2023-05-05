using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private AudioSource MenuMusic;
    public TMP_InputField name1;
    public void Play()
    {
        PersistentData.Instance.SetName(name1.text);
        PersistentData.Instance.SetScore(0);
        SceneManager.LoadScene("GamePlay");
    }
    public void Instruction()
    {
        SceneManager.LoadScene("Instruction");
    }
    public void Setting()
    {
        SceneManager.LoadScene("Setting");
    }
    public void HighScore()
    {
        SceneManager.LoadScene("EndGame");
    }
    void Start()
    {
        MenuMusic.Play();
    }

}
