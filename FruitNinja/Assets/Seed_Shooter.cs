using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed_Shooter : MonoBehaviour
{
    public Rigidbody seed;
    public GameObject fruit;
    public GameObject Target;
    public int rate_of_fire;
    public int range_to_fire;
    private float distance_to_target;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distance_v = Target.transform.position - transform.position;
        float distance = distance_v.magnitude;
        //Debug.Log(distance);
        if (distance <= range_to_fire)
        {


            float chance = Random.Range(1, rate_of_fire);
            if (chance == 1)
            {

                var projectile = Instantiate(seed, fruit.transform.position, fruit.transform.rotation);
            }
        }

    }
}