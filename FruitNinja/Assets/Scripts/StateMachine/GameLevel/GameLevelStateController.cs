/* Description: Holds the context variables as well as the state for next frame (Defaults to current state).*/
public abstract class GameLevelStateController : BaseState<GameLevelStateMachine.GameLevelState>
{
    protected GameLevelContext Context;
    protected GameLevelStateMachine.GameLevelState NextState;
    public GameLevelStateController(GameLevelContext context, GameLevelStateMachine.GameLevelState stateKey) : base(stateKey)
    {
        Context = context;
        NextState = stateKey;
    }
}