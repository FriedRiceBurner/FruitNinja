using UnityEngine;

public class PlayerDefaultState : PlayerStateController
{
    public PlayerDefaultState(PlayerContext context, PlayerStateMachine.PlayerState stateKey) : base(context, stateKey)
    {
        PlayerContext Context = context;
    }

    public override void EnterState()
    {
        Debug.Log("Enter default player state");
        
    }

    public override void ExitState()
    {
        Debug.Log("Exit default player state");
        // throw new System.NotImplementedException();
    }

    public override void UpdateState()
    {
        Debug.Log("Update default player state");

        // To move to a different state, set NextState variable here
        // NextState = ...
        // throw new System.NotImplementedException();
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
