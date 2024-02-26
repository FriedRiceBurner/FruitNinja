/* Description: Holds the context variables as well as the state for next frame (Defaults to current state).*/
public abstract class PlayerStateController : BaseState<PlayerStateMachine.PlayerState>
{
    protected PlayerContext Context;
    protected PlayerStateMachine.PlayerState NextState;
    public PlayerStateController(PlayerContext context, PlayerStateMachine.PlayerState stateKey) : base(stateKey)
    {
        Context = context;
        NextState = stateKey;
    }
}
