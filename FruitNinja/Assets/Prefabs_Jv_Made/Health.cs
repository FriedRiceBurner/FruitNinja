using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    
    public int health;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Fruits")
        {
            Debug.Log("Ate fruit");
            //yield return new WaitForSeconds(2);
            Destroy(col.gameObject);
            health -=1;
            if (health == 0) {
                Destroy(gameObject);
            
            }
        }

      

    }

}
