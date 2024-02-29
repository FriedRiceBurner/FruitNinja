using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Time_to_live : MonoBehaviour
{
    public int TimetoLive;
    public int rotationSpeed;
    public int speed;
    public GameObject Target;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, TimetoLive);
    }

    // Update is called once per frame
    void Update()
    {
        //// Get the direction to the target
        //Vector3 direction = Target.transform.position - gameObject.transform.position;
        //// Create a rotation to look at the target
        //Quaternion targetRotation = Quaternion.LookRotation(direction);
        //// Slerp to interpolate smoothly towards the target rotation
        //gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        rb.AddForce(transform.forward * speed);
    }
}
