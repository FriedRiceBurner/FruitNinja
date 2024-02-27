using UnityEngine;
using Oculus;

public class Shoot_Shuriken : MonoBehaviour
{
    public Rigidbody star;
    public GameObject controller;
    public int speed;

    void Update()
    {
        // Check for input from Oculus Touch controllers
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
          
        {
        
            // Spawn the object at the spawn point
            var shuriken=Instantiate(star,controller.transform.position, controller.transform.rotation);
            shuriken.AddForce(controller.transform.forward * speed);



        }
    }

    
}