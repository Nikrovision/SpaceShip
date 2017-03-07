using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRocket : MonoBehaviour {

    public float speed;

    void OnCollisionEnter(Collider other)
    {
        if (other.gameObject.tag == "Asteroid")
        {
            Destroy(gameObject);
        }
    }
   
    public void Start()
    { //Задаем ракете направление движения и скорость
        GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().transform.forward * speed;
    }
}