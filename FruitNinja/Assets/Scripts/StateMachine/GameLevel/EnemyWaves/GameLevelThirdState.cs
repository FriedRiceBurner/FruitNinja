using UnityEngine;

public class GameLevelThirdState : GameLevelStateController
{
    public GameLevelThirdState(GameLevelContext context, GameLevelStateMachine.GameLevelState stateKey) : base(context, stateKey)
    {
        GameLevelContext Context = context;
    }

    public override void EnterState()
    {
        Context.GetThirdLevelEnemies().SetActive(true);

    }

    public override void ExitState()
    {
        Object.Destroy(Context.GetThirdLevelEnemies());
    }

    public override void UpdateState()
    {
        if (Context.GetThirdLevelEnemies().transform.childCount == 0)
        {
            NextState = GameLevelStateMachine.GameLevelState.GameFinished;
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