using UnityEngine;

public class GameFinishedState: GameLevelStateController
{
    public GameFinishedState(GameLevelContext context, GameLevelStateMachine.GameLevelState stateKey) : base(context, stateKey)
    {
        GameLevelContext Context = context;
    }

    public override void EnterState()
    {
        PauseMenu.QuitGame();
    }

    public override void ExitState()
    {
    }

    public override void UpdateState()
    {
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