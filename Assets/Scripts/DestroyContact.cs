using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyContact : MonoBehaviour {

    public GameObject explosion;

    void OnTriggerEnter(Collider other)
    {//Разрушение астероида при столкновении с ракетой
            if (other.gameObject.tag == "Rocket")
            {
                Score.score += 1;
                Instantiate(explosion, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            //Разрушение астероида при столкновении с кораблем
            else if (other.gameObject.tag == "Player")
            {
                Score.score += 1;
                Instantiate(explosion, transform.position, transform.rotation);
                Destroy(gameObject);
            }
    }
}