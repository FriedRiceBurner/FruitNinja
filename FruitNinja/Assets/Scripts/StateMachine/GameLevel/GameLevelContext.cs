using Unity.XR.CoreUtils;
using UnityEngine;

/* Description: Holds variables that all the states may need access to and the get methods*/
public class GameLevelContext
{
    [SerializeField]
    private PlayerStateMachine _playerStateMachine;
    [SerializeField]
    private GameObject _firstLevelEnemies;
    [SerializeField]
    private GameObject _secondLevelEnemies;
    [SerializeField]
    private GameObject _thirdLevelEnemies;
    public GameLevelContext(PlayerStateMachine playerStateMachine, GameObject firstLevelEnemies, GameObject secondLevelEnemies, GameObject thirdLevelEnemies)
    {
        _playerStateMachine = playerStateMachine;
        _firstLevelEnemies = firstLevelEnemies;
        _secondLevelEnemies = secondLevelEnemies;
        _thirdLevelEnemies = thirdLevelEnemies;
    }

    public PlayerContext GetPlayerContext()
    {
        return _playerStateMachine.getPlayerContext();
    }

    public GameObject GetFirstLevelEnemies()
    {
        return _firstLevelEnemies;
    }
    public GameObject GetSecondLevelEnemies()
    {
        return _secondLevelEnemies;
    }
    public GameObject GetThirdLevelEnemies()
    {
        return _thirdLevelEnemies;
    }
}