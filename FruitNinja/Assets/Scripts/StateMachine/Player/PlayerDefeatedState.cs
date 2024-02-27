using UnityEngine;

public class PlayerDefeatedState : PlayerStateController
{
    public PlayerDefeatedState(PlayerContext context, PlayerStateMachine.PlayerState stateKey) : base(context, stateKey)
    {
        PlayerContext Context = context;
    }

    public override void EnterState()
    {
        Debug.Log("Enter Defeated player state");
        PauseMenu.QuitGame();
    }

    public override void ExitState()
    {
    }

    public override void UpdateState()
    {
    }

    public override PlayerStateMachine.PlayerState GetNextState()
    {
        return NextState;
    }

    public override void OnTriggerEnter(Collider other)
    {
        throw new System.NotImplementedException();
    }

    public override void OnTriggerStay(Collider other)
    {
        throw new System.NotImplementedException();
    }

    public override void OnTriggerExit(Collider other)
    {
        throw new System.NotImplementedException();
    }
}