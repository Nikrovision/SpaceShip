using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour {

    private ParticleSystem PS;

    void Start()
    {
        PS = (ParticleSystem)GetComponent(typeof(ParticleSystem));
    }

    void Update()
    {
        if (PS)
            if (!PS.IsAlive())
                Destroy(gameObject);
    }
}
