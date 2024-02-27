using UnityEngine;
using UnityEngine.Assertions;

/* Initializes Enemy State classes and is placed in a game object */
public class AppleStateMachine : StateManager<AppleStateMachine.EnemyState>
{
    public enum EnemyState
    {
        Default
    }

    private AppleContext _context;
    [SerializeField] private float health;
    
    void Awake()
    {
        ValidateConstraints();
        _context = new AppleContext(health);
        InitializeStates();
    }


    private void ValidateConstraints()
    {
        Assert.IsTrue(health > 0f, "Health is not set");
    }
    
    private void InitializeStates()
    {
        States.Add(EnemyState.Default, new AppleDefaultState(_context, EnemyState.Default));
        CurrentState = States[EnemyState.Default];
    }
}
