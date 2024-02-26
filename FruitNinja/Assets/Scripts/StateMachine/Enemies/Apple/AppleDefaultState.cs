using UnityEngine;

public class AppleDefaultState : AppleStateController
{
    public AppleDefaultState(AppleContext context, AppleStateMachine.EnemyState stateKey) : base(context, stateKey)
    {
        AppleContext Context = context;
    }

    public override void EnterState()
    {
        Debug.Log("Enter default apple state");
        
    }

    public override void ExitState()
    {
        Debug.Log("Exit default apple state");
        // throw new System.NotImplementedException();
    }

    public override void UpdateState()
    {
        Debug.Log("Update default apple state");

        // To move to a different state, set NextState variable here
        // NextState = ...
        // throw new System.NotImplementedException();
    }

    public override AppleStateMachine.EnemyState GetNextState()
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

