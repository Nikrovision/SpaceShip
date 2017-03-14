using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    [Header("Button")]
    public Button continueButton;
    public Button restartButton;
    public Button mainMenuButton;
    public float timer;
    public bool isPause;
    public GameObject menu;

    void Update()
    {
        Time.timeScale = timer;
        if (Input.GetKeyDown(KeyCode.Escape) && isPause == false)//Если нажата ESC и пауза не стоит, ставим
        {
            isPause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPause == true)//Если стоит, снимаем
        {
            isPause = false;
        }
        if (isPause == true)
        {
            timer = 0;
            menu.SetActive(true);
        }
        else if (isPause == false)
        {
            timer = 1f;
            menu.SetActive(false);
        }
    }

    public void ContinueGame(bool state)
    {
        isPause = state;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
