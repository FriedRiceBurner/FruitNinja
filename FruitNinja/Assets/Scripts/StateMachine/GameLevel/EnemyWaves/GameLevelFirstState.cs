using UnityEngine;

public class GameLevelFirstState : GameLevelStateController
{
    public GameLevelFirstState(GameLevelContext context, GameLevelStateMachine.GameLevelState stateKey) : base(context, stateKey)
    {
        GameLevelContext Context = context;
    }

    public override void EnterState()
    {
        Debug.Log("Enter First GameLevel state");
        Context.GetFirstLevelEnemies().SetActive(true);
        // spawn enemies

    }

    public override void ExitState()
    {
        Object.Destroy(Context.GetFirstLevelEnemies());
        Debug.Log("Exit First GameLevel state");
        // open next door
    }

    public override void UpdateState()
    {
        if (Context.GetFirstLevelEnemies().transform.childCount == 0 || Time.time >= 15f)
        {
            NextState = GameLevelStateMachine.GameLevelState.SecondLevel;
        }
        Debug.Log("Update First GameLevel state");
        // check if all enemies defeated
        // if so, move to next level
        // NextState = ...
        // throw new System.NotImplementedException();
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