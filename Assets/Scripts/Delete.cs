using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour {

    private ParticleSystem ps;

    void Start()
    {
        ps = (ParticleSystem)GetComponent(typeof(ParticleSystem));
    }

    void Update()
    {
        if (ps)
            if (!ps.IsAlive())
                Destroy(gameObject);
    }
}
