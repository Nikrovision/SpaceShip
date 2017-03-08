using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text pointsText;

    public static float score = 0;
    
    void FixedUpdate()
    {
        pointsText.text = "Score: " + score;
    }
}
