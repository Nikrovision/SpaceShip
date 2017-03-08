using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text pointsText, gameoverText;

    public static float score = 0;
    
    void FixedUpdate()
    {
        pointsText.text = "Score: " + score;
    }

    void Update()
    {
        if (score >= 50)
        {
            gameoverText.text = "YOU WIN";
        }
    }
}
