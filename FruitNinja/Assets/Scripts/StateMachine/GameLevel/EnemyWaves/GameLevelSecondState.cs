using UnityEngine;

public class GameLevelSecondState : GameLevelStateController
{
    public GameLevelSecondState(GameLevelContext context, GameLevelStateMachine.GameLevelState stateKey) : base(context, stateKey)
    {
        GameLevelContext Context = context;
    }

    public override void EnterState()
    {
        Debug.Log("Enter Second GameLevel state");
        Context.GetSecondLevelEnemies().SetActive(true);
        // spawn enemies
    }

    public override void ExitState()
    {
        Object.Destroy(Context.GetSecondLevelEnemies());
        Debug.Log("Exit Second GameLevel state");
        // throw new System.NotImplementedException();
    }

    public override void UpdateState()
    {
        if (Context.GetSecondLevelEnemies().transform.childCount == 0)
        {
            NextState = GameLevelStateMachine.GameLevelState.ThirdLevel;
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