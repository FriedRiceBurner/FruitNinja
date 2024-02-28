using UnityEngine;
using Oculus;

public class Shoot_Shuriken : MonoBehaviour
{
    public Rigidbody star;
    public GameObject controller;
    public GameObject[] shurikens_available;
    public int speed;
    private int count=0;

    void Update()
    {
        // Check for input from Oculus Touch controllers
        if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch))
          
        {
            // Spawn the object at the spawn point
            var shuriken=Instantiate(star,controller.transform.position, controller.transform.rotation);
            shuriken.AddForce(controller.transform.forward * speed);
            count++;
            if (count % 10 == 0)
            {
                shurikens_available[(count/10)-1].SetActive(false);
            }

        }
    }

    
}