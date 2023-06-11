using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameWin : MonoBehaviour
{
    AudioSource source;
    public void Setup()
    {
        source = GetComponent<AudioSource>();
        gameObject.SetActive(true);
        source.Play();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
