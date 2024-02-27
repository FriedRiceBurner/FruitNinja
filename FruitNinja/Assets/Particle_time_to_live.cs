using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_time_to_live : MonoBehaviour
{
    public int TimetoLive;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, TimetoLive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
