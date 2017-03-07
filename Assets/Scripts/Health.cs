using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float MaxHP;
    public float CurrentHP;
    public float Percent;
    public Texture2D text2d;
    public GameObject PlayerExplosion;

    void OnGUI()
    {
        Percent = CurrentHP / MaxHP;

        GUI.DrawTexture(new Rect(Screen.width - 150, Screen.height - 15, 150 * Percent, 10), text2d);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Asteroid")
        {
            CurrentHP -= 20;
        }
    }
    
    void Update()
    {
        if (CurrentHP <= 0)
        {
            Instantiate(PlayerExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        DontDestroyOnLoad(GameObject.Find("Player"));
    }
}