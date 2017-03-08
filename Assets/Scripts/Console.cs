using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
    public Text contentText;
    private bool console = false;

    void Update()
    {
        if (console == true)
        {
            OnEnable();
        }
        else
        {
            OnDisable();
        }
    }

    void OnEnable()
    {
        Application.RegisterLogCallback(HandleLog);
    }

    void OnDisable()
    {
        Application.RegisterLogCallback(null);
    }

    void HandleLog(string logString, string stackTrace, LogType type)
    {
        contentText.text = "" + logString;
    }
}