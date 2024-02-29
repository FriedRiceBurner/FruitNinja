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
        HandlePlayerTeleport();
    }

    public override PlayerStateMachine.PlayerState GetNextState()
    {
        return NextState;
    }

    public override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fruits"))
        {
            //yield return new WaitForSeconds(2);
            Object.Destroy(other.gameObject);
            Context.SetHealth(Context.GetHealth() - 5);

            if (Context.GetHealth() == 0)
            {
                NextState = PlayerStateMachine.PlayerState.PlayerDefeated;
            }
        }
        else if (other.gameObject.CompareTag("Food"))
        {
            Object.Destroy(other.gameObject);
            Context.SetHealth(Context.GetHealth() + 5);
        }
        else
        {
            return;
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

    public void HandlePlayerTeleport()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Context.GetPlayerTeleporter().ToggleDisplay(true);
        }

        if(OVRInput.GetUp(OVRInput.Button.One))
        {
            Context.GetPlayerTeleporter().Teleport();
            Context.GetPlayerTeleporter().ToggleDisplay(false);
        }
    }
}
