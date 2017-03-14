using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyContact : MonoBehaviour {

    public GameObject explosion;
    public GameObject vzriv;
    public Logger content;
    public Vector3 temp;

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

            else if (other.gameObject.tag == "Bomba")
            {
                Score.score += 2;
                Instantiate(vzriv, transform.position, transform.rotation);
                Destroy(gameObject);
                Debug.Log("Bomba made some BOOM! U're saw that?!");
        }

           /* else if (other.gameObject.tag == "Asteroid")
             {
            temp = other.gameObject.transform.position;
             if (Mathf.Sqrt(Mathf.Pow(transform.position.x - temp.x, 2) + Mathf.Pow(transform.position.y - temp.y, 2)+ Mathf.Pow(transform.position.z - temp.z, 2)) < 300)
            {
                Destroy(gameObject);
                Score.score += 1;
            }
             }*/
    }
}