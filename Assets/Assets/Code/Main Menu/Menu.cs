﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Переменная для нумерации окон
    public int window;
    public Menu menu;
    //public QualityLevel Fastest;

    void Start()
    {
        window = 1;
    }
    //Вывод меню
    void OnGUI()
    {
        //Вывод меню по центру экрана
        GUI.BeginGroup(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 200));
        //При window = 1 ==>
        if (window == 1)
        {
            if (GUI.Button(new Rect(10, 30, 180, 30), "Start"))
            {
                window = 2;
            }
            if (GUI.Button(new Rect(10, 70, 180, 30), "Settings"))
            {
                window = 3;
            }
            if (GUI.Button(new Rect(10, 110, 180, 30), "Exit"))
            {
                window = 4;
            }
        }
        //Если нажата кнопка "Start"
        if (window == 2)
        {
            GUI.Label(new Rect(50, 10, 180, 30), "Choose Level");
            if (GUI.Button(new Rect(10, 40, 180, 30), "Level 1"))
            {
                Debug.Log("Level 1");
                SceneManager.LoadScene("Main");
            }
            if (GUI.Button(new Rect(10, 80, 180, 30), "Level 2"))
            {
                Debug.Log("Level 2");
                SceneManager.LoadScene("Level 2");
            }
            if (GUI.Button(new Rect(10, 120, 180, 30), "Level 3"))
            {
                Debug.Log("Level 3");
                SceneManager.LoadScene(3);
            }
            if (GUI.Button(new Rect(10, 160, 180, 30), "Back"))
            {
                window = 1;
            }
        }
        //Если нажата кнопка "Settings"
        if (window == 3)
        {
            GUI.Label(new Rect(50, 10, 180, 30), "Settings");
            if (GUI.Button(new Rect(10, 120, 180, 30), "Quality"))
            {
                window = 5;
            }

            if (GUI.Button(new Rect(10, 160, 180, 30), "Back"))
            {
                window = 1;
            }
        }
        //Если нажата кнопка "Выход"
        if (window == 4)
        {
            GUI.Label(new Rect(50, 10, 180, 30), "Are u sure?");
            if (GUI.Button(new Rect(10, 40, 180, 30), "Yeap"))
            {
                Application.Quit();
            }
            if (GUI.Button(new Rect(10, 80, 180, 30), "Oh, no, sorry"))
            {
                window = 1;
            }
        }

        if (window == 5)
        {
            GUI.Label(new Rect(50, 10, 180, 30), "Quality Settings");
            if (GUI.Button(new Rect(10, 40, 180, 30), "Low"))
            {
                Debug.Log("Low Quality");
                QualitySettings.SetQualityLevel(0);
            }
            if (GUI.Button(new Rect(10, 80, 180, 30), "Medium"))
            {
                Debug.Log("Medium Quality");
                QualitySettings.SetQualityLevel(3);
            }
            if (GUI.Button(new Rect(10, 120, 180, 30), "High"))
            {
                Debug.Log("High Quality");
                QualitySettings.SetQualityLevel(5);
            }
            if (GUI.Button(new Rect(10, 160, 180, 30), "Back"))
            {
                window = 1;
            }
        }
        GUI.EndGroup();
    }
}