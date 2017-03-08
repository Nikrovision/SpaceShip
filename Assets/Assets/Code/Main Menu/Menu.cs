using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LowQuality : MonoBehaviour
{
    void Start()
    {
        QualitySettings.SetQualityLevel(0);
    }
}