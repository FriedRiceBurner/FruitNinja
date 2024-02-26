using Unity.XR.CoreUtils;
using UnityEngine;

/* Description: Holds variables that all the states may need access to and the get methods*/
public class AppleContext
{
    [SerializeField] private float _health;
    public AppleContext(float Health)
    {
        _health = Health;
    }

    public float GetHealth()
    {
        return _health;
    }

    
}
