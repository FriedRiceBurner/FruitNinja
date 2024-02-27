using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.Assertions;

public class GameLevelStateMachine : StateManager<GameLevelStateMachine.GameLevelState>
{
    public enum GameLevelState
    {
        Default,
        FirstLevel,
        SecondLevel,
        ThirdLevel,
        GameFinished
    }

    private GameLevelContext _context;
    
    [SerializeField]
    private PlayerStateMachine playerStateMachine;
    [SerializeField]
    private GameObject firstLevelEnemies;
    [SerializeField]
    private GameObject secondLevelEnemies;
    [SerializeField]
    private GameObject thirdLevelEnemies;
    void Awake()
    {
        ValidateConstraints();
        _context = new GameLevelContext( playerStateMachine, firstLevelEnemies, secondLevelEnemies, thirdLevelEnemies);
        InitializeStates();
    }

    public GameLevelContext getGameLevelContext()
    {
        return _context;
    }
    private void ValidateConstraints()
    {
        Assert.IsNotNull(playerStateMachine, "Player state machine is not assigned");
        Assert.IsNotNull(firstLevelEnemies, "First level enemies is not assigned");
        Assert.IsNotNull(secondLevelEnemies, "Second level enemies is not assigned");
        Assert.IsNotNull(thirdLevelEnemies, "Third level enemies is not assigned");
    }
    
    private void InitializeStates()
    {
        States.Add(GameLevelState.Default, new GameLevelDefaultState(_context, GameLevelState.Default));
        States.Add(GameLevelState.FirstLevel, new GameLevelFirstState(_context, GameLevelState.FirstLevel)); 
        States.Add(GameLevelState.SecondLevel, new GameLevelSecondState(_context, GameLevelState.SecondLevel));
        States.Add(GameLevelState.ThirdLevel, new GameLevelThirdState(_context, GameLevelState.ThirdLevel));
        States.Add(GameLevelState.GameFinished, new GameFinishedState(_context, GameLevelState.GameFinished));

        CurrentState = States[GameLevelState.Default];
    }
}