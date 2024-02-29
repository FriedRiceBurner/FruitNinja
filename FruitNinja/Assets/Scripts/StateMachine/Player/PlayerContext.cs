using Unity.XR.CoreUtils;
using UnityEngine;

/* Description: Holds variables that all the states may need access to and the get methods*/
public class PlayerContext
{
    [SerializeField] private OVRPlayerController _ovrPlayerController;    
    [SerializeField] private GameLevelStateMachine _gameLevelStateMachine;
    [SerializeField] private VRTeleporter _playerTeleporter;


    private float Health;
    private float Radius;
    public PlayerContext(OVRPlayerController ovrPlayerController, GameLevelStateMachine gameLevelStateMachine, VRTeleporter playerTeleporter)
    {
        _ovrPlayerController = ovrPlayerController;
        _gameLevelStateMachine = gameLevelStateMachine;
        _playerTeleporter = playerTeleporter;
        Health = 100f;
        Radius = .2f;
    }

    public OVRPlayerController GetOVRPlayerController()
    {
        return _ovrPlayerController;
    }

    public VRTeleporter GetPlayerTeleporter()
    {
        return _playerTeleporter;
    }

    public float GetHealth()
    {
        return Health;
    }

    public GameLevelStateMachine getGameLevelStateMachine()
    {
        return _gameLevelStateMachine;
    }
    public void SetHealth(float newValue)
    {
        Health = newValue;
    }
    public Vector3 GetRandomPosition()
    {
        Vector3 randomPosition = Vector3.zero;
        bool positionFound = false;
        int attempts = 0;

        while (!positionFound && attempts < 100)
        {
            Vector3 candidatePosition = _ovrPlayerController.gameObject.transform.position + Random.insideUnitSphere * Radius;
            Debug.Log("cd" + candidatePosition);
            // candidatePosition.y = 0f; // Ensure objects are instantiated at ground level or desired height

            /*if (!Physics.CheckSphere(candidatePosition, .01f))
            {
                randomPosition = candidatePosition;
                positionFound = true;
            }*/
            positionFound = true;
            randomPosition = candidatePosition;
            attempts++;
        }

        return randomPosition;
    }
}
