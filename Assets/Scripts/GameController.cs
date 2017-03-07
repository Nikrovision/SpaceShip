using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject hazard;
    public int hazardCount;
    public float spawnWait, startWait, waveWait;
    public float x, y, z;

    IEnumerator SpawnAsteroids()
    {
        yield return new WaitForSeconds(startWait);//Стартовая задержка респауна астероидов
        while(true)
        {
            for (int i = 0; i < hazardCount; i++)
            {//Задаем координаты появления астероидов
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, new Vector3(Random.Range(-x, x),Random.Range(-y, y),Random.Range(-z, z)), spawnRotation);
                yield return new WaitForSeconds(spawnWait);//Задержка между появлениями астероидов
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
    void Start()
    {
        StartCoroutine(SpawnAsteroids());
    }
}