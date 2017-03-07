using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPause : MonoBehaviour {

    public float Timer;
    public bool IsPause;
    public bool GuiPause;

    void Update()
    {
        Time.timeScale = Timer;
        if (Input.GetKeyDown(KeyCode.Escape) && IsPause == false)//Если нажата ESC и пауза не стоит, ставим
        {
            IsPause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && IsPause == true)//Если стоит, снимаем
        {
            IsPause = false;
        }
        if (IsPause == true)
        {
            Timer = 0;
            GuiPause = true;

        }
        else if (IsPause == false)
        {
            Timer = 1f;
            GuiPause = false;

        }
    }
    public void OnGUI()
    {
        if (GuiPause == true)
        {
            Cursor.visible = true;// включаем отображение курсора
            if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2) - 150f, 150f, 45f), "Continue"))
            {
                IsPause = false;
                Timer = 0;
                Cursor.visible = false;
            }
            if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2) -100, 150f, 45f), "Restart"))
            {
                IsPause = false;
                Timer = 0;
                Application.LoadLevel(Application.loadedLevel);
            }
            if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2), 150f, 45f), "Starting Menu"))
            {
                IsPause = false;
                Timer = 0;
                Application.LoadLevel("Menu");
            }
        }
    }
}