// TEMPLATE 1: PLAYER STATS SCRIPTABLE OBJECT
// ==========================================
// Instructions: Fill in the missing code where indicated by TODO comments
using UnityEngine;

// TODO: Add the CreateAssetMenu attribute with appropriate fileName and menuName

public class PlayerStats : ScriptableObject
{
    // TODO: Add public variables for health, speed, and jumpForce
    int health;
    float speed;
    float jumpForce;

    public void Reset()
    {
        health = 100;
        speed = 1;
        jumpForce = 5;
    }
}

