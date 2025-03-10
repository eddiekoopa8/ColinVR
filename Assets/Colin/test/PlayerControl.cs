// PLAYER CONTROLLER THAT USES THE STATS SCRIPTABLE OBJECT
// ==========================================
using UnityEngine;

public class Player : MonoBehaviour
{
    // TODO: Add a serialized field for referencing the PlayerStats scriptable object

    private Rigidbody2D rb;
    private float currentHealth;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // TODO: Initialize the player's currentHealth from the scriptable object
    }

    private void Update()
    {
        // Simple movement using the speed from the scriptable object
        float horizontalInput = Input.GetAxis("Horizontal");
        // TODO: Use the speed from the scriptable object for movement

        // Simple jump using the jumpForce from the scriptable object
        if (Input.GetButtonDown("Jump"))
        {
            // TODO: Use the jumpForce from the scriptable object
        }
    }

    public void TakeDamage(float amount)
    {
        // TODO: Reduce currentHealth and check if player should die
    }
}
