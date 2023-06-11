using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    public void startButton()
    {
        Debug.Log("wef");
        SceneManager.LoadScene("SampleScene");
    }
}

