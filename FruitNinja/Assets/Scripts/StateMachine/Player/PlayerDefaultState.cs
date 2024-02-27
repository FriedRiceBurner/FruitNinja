using UnityEngine;

public class PlayerDefaultState : PlayerStateController
{
    public PlayerDefaultState(PlayerContext context, PlayerStateMachine.PlayerState stateKey) : base(context, stateKey)
    {
        PlayerContext Context = context;
    }

    public override void EnterState()
    {
    }

    public override void ExitState()
    {
    }

    public override void UpdateState()
    {
        Debug.Log(Context.GetHealth());
    }

    public override PlayerStateMachine.PlayerState GetNextState()
    {
        return NextState;
    }

    public override void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Fruits")) return;
        
        //yield return new WaitForSeconds(2);
        Object.Destroy(other.gameObject);
        Context.SetHealth(Context.GetHealth() - 1);
        if (Context.GetHealth() == 0)
        {
            NextState = PlayerStateMachine.PlayerState.PlayerDefeated;
        }
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
