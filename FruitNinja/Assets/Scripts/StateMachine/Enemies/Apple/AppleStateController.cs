/* Description: Holds the context variables as well as the state for next frame (Defaults to current state).*/
public abstract class AppleStateController : BaseState<AppleStateMachine.EnemyState>
{
    protected AppleContext Context;
    protected AppleStateMachine.EnemyState NextState;
    public AppleStateController(AppleContext context, AppleStateMachine.EnemyState stateKey) : base(stateKey)
    {
        Context = context;
        NextState = stateKey;
    }
}
