using Unity.XR.CoreUtils;
using UnityEngine;

/* Description: Holds variables that all the states may need access to and the get methods*/
public class PlayerContext
{
    [SerializeField] private XROrigin _xrOrigin;
    private float Health;
    private float StandingHeight;
    private float CrouchingHeight;
    public PlayerContext(XROrigin xrOrigin)
    {
        _xrOrigin = xrOrigin;
        StandingHeight = 1.36144f;
        CrouchingHeight = StandingHeight * 0.6f;
        Health = 100f;
    }

    public XROrigin GetXROrigin()
    {
        return _xrOrigin;
    }

    public float GetStandingHeight()
    {
        return StandingHeight;
    }

    public float GetCrouchingHeight()
    {
        return CrouchingHeight;
    }
    public float GetHealth()
    {
        return Health;
    }
    
}
