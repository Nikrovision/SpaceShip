using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public bool startButton = false;
    public bool quitButton = false;
    public bool lowQualityButton = false;
    public bool mediumQualityButton = false;
    public bool highQualityButton = false;

    void OnMouseDown()
    {
        if (startButton == true)
        {
            SceneManager.LoadScene("Main");
        }

        else if (quitButton == true)
        {
            Application.Quit();
        }

        else if (lowQualityButton == true)
        {
            QualitySettings.SetQualityLevel(1);
        }

        else if (mediumQualityButton == true)
        {
            QualitySettings.SetQualityLevel(3);
        }

        else if (highQualityButton == true)
        {
            QualitySettings.SetQualityLevel(5);
        }
    }

    void Update()
    {
        OnMouseDown();
    }
}