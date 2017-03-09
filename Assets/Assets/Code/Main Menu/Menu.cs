using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [Header("Button")]
    public Button startButton;
    public Button quitButton;
    public Button lowQualityButton;
    public Button mediumQualityButton;
    public Button highQualityButton;

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LowQuality()
    {
        QualitySettings.SetQualityLevel(1);
    }

    public void MediumQuality()
    {
        QualitySettings.SetQualityLevel(3);
    }

    public void HighQuality()
    {
        QualitySettings.SetQualityLevel(5);
    }


}