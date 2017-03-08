using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collison : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        //Столкновение с объектом
        if (other.gameObject.name == "asteroid")
        {
            //Указание на объект с которым столкнулись 
            Debug.Log("Our ship collided with an asteroid");
        }
        else if (other.gameObject.name == "Protal")
        {
            //Указание на объект с которым столкнулись 
            Debug.Log("Our ship moved throught the portal");
        }
    }
}
