using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public float maxHP;
    public float currentHP;
    public float percent;
    public Texture2D text2d;
    public GameObject playerExplosion;
    public Text gameoverText;


    void OnGUI()
    {
        percent = currentHP / maxHP;

        GUI.DrawTexture(new Rect(Screen.width - 150, Screen.height - 15, 150 * percent, 10), text2d);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Asteroid")
        {
            currentHP -= 20;
        }
    }
    
    void Update()
    {
        if (currentHP <= 0)
        {
            Instantiate(playerExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
            gameoverText.text = "GAME OVER";
        }
    }

    void Start()
    {
        gameoverText.text = "";
    }
}