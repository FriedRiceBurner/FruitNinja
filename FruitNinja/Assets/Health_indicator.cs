using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_indicator : MonoBehaviour

{
    public GameObject Health;
    public PlayerStateMachine playerStateMachine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other){ 
        Health.transform.localScale=new Vector3 (1,1,1) * (playerStateMachine.getPlayerContext().GetHealth() / 100) ;
    }
}
