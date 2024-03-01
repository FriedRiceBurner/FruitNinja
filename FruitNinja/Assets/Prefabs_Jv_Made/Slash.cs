using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    public GameObject Particles;
    public AudioSource Sound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Fruits")
        {
            Debug.Log("Hit fruit");
            //yield return new WaitForSeconds(2);
            Instantiate(Particles, col.gameObject.transform.position, Quaternion.identity); ;
            Destroy(col.gameObject);
            Sound = GetComponent<AudioSource>();
            Sound.Play(0);

        }


    }
}