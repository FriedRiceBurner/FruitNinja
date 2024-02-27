using UnityEngine;

public class GameLevelDefaultState : GameLevelStateController
{
    public GameLevelDefaultState(GameLevelContext context, GameLevelStateMachine.GameLevelState stateKey) : base(context, stateKey)
    {
        GameLevelContext Context = context;
    }

    public override void EnterState()
    {
    }

    public override void ExitState()
    {
    }

    public override void UpdateState()
    {
        if (Time.time >= 5f)
        {
            NextState = GameLevelStateMachine.GameLevelState.FirstLevel;
        }
    }

    public override GameLevelStateMachine.GameLevelState GetNextState()
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