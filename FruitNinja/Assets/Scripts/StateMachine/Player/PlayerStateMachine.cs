using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Serialization;

/* Initializes Player State classes and is placed in a game object */
public class PlayerStateMachine : StateManager<PlayerStateMachine.PlayerState>
{
    public enum PlayerState
    {
        Default,
        PlayerDefeated
    }

    private PlayerContext _context;
    [SerializeField] private OVRPlayerController _ovrPlayerController;
    [SerializeField] private GameLevelStateMachine _gameLevelStateMachine;
    [SerializeField] private VRTeleporter _playerTeleporter;


    void Awake()
    {
        ValidateConstraints();
        _context = new PlayerContext(_ovrPlayerController, _gameLevelStateMachine, _playerTeleporter);
        InitializeStates();
    }

    public PlayerContext getPlayerContext()
    {
        return _context;
    }
    private void ValidateConstraints()
    {
        Assert.IsNotNull(_ovrPlayerController, "XR Origin is not assigned");
    }
    
    private void InitializeStates()
    {
        States.Add(PlayerState.Default, new PlayerDefaultState(_context, PlayerState.Default));
        States.Add(PlayerState.PlayerDefeated, new PlayerDefeatedState(_context, PlayerState.PlayerDefeated));
        CurrentState = States[PlayerState.Default];
    }
}