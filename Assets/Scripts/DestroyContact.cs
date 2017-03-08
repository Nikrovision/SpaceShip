using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyContact : MonoBehaviour {

    public GameObject explosion;
    public Logger content;

    void OnTriggerEnter(Collider other)
    {//Разрушение астероида при столкновении с ракетой
            if (other.gameObject.tag == "Rocket")
            {
                Score.score += 1;
                Instantiate(explosion, transform.position, transform.rotation);
                Destroy(gameObject);
                Debug.Log("The rocket destroyed an asteroid");
            }
            //Разрушение астероида при столкновении с кораблем
            else if (other.gameObject.tag == "Player")
            {
                Score.score += 1;
                Instantiate(explosion, transform.position, transform.rotation);
                Destroy(gameObject);
                Debug.Log("Ship got a damage! Be carefull!");
            }
    }
}