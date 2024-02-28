using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stab : MonoBehaviour
{
  
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
            Debug.Log("stabbed");
            col.transform.parent = gameObject.transform;
        }
    }
}
