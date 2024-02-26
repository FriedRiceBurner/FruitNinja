using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.Assertions;

/* Initializes Player State classes and is placed in a game object */
public class PlayerStateMachine : StateManager<PlayerStateMachine.PlayerState>
{
    public enum PlayerState
    {
        Default
    }

    private PlayerContext _context;
    [SerializeField] private XROrigin _xrOrigin;
    
    void Awake()
    {
        ValidateConstraints();
        _context = new PlayerContext(_xrOrigin);
        InitializeStates();
    }

    public PlayerContext getPlayerContext()
    {
        return _context;
    }
    private void ValidateConstraints()
    {
        Assert.IsNotNull(_xrOrigin, "XR Origin is not assigned");
    }
    
    private void InitializeStates()
    {
        States.Add(PlayerState.Default, new PlayerDefaultState(_context, PlayerState.Default));
        CurrentState = States[PlayerState.Default];
    }
}