using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;

public class PlayerHealthUpdate : MonoBehaviour
{
    public PlayerStateMachine playerStateMachine;
    public TextMeshProUGUI playerHealth;

    private void Start()
    {
        Assert.IsNotNull(playerStateMachine, "Player state machine is not assigned");
        Assert.IsNotNull(playerHealth, "Player health text is not assigned");
    }

    private void Update()
    {
        UpdatePlayerHealthText(playerStateMachine.getPlayerContext().GetHealth());
    }

    private void UpdatePlayerHealthText(float health)
    {
        playerHealth.text = "Health: " + health + "%";
    }
}
