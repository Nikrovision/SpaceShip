using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SetPause : MonoBehaviour {

    public float timer;
    public bool isPause;
    public bool guiPause;

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
            guiPause = true;

        }
        else if (isPause == false)
        {
            timer = 1f;
            guiPause = false;

        }
    }
    public void OnGUI()
    {
        if (guiPause == true)
        {
            Cursor.visible = true;// включаем отображение курсора
            if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2) - 150f, 150f, 45f), "Continue"))
            {
                isPause = false;
                timer = 0;
                Cursor.visible = false;
            }
            if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2) -100, 150f, 45f), "Restart"))
            {
                isPause = false;
                timer = 0;
                Application.LoadLevel(Application.loadedLevel);
            }
            if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2), 150f, 45f), "Starting Menu"))
            {
                isPause = false;
                timer = 0;
                Application.LoadLevel("Menu");
            }
        }
    }
}